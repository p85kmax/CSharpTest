//using ContainerInspector.Algo;/
//using ContainerInspector.Data;
//using ContainerInspector.Device;
using DynMvp.Devices.Dio;
using DynMvp.UI;
using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ContainerInspector.UI
{
    public partial class ImageViewer : UserControl
    {
        #region 생성자
        public ImageViewer(int camIndex)
        {
            InitializeComponent();

            CamIndex = camIndex;
            lblViewerTitle.Text = "Cam" + (camIndex + 1).ToString();

            ImagePanel.Dock = DockStyle.Fill;
            ImagePanel.Margin = new Padding(0);

            panelImage.Controls.Add(ImagePanel);

            DoubleBufferPanel();

            // UI Timer
            UITimer.Interval = 100;
            UITimer.Tick += UITimer_Tick;
            ////

            string ioName = string.Format("Reject{0}Out", CamIndex + 1);
            DigitalIoHandler digitalIoHandler = DeviceManager.Instance().DigitalIoHandler;

            if (SystemConfig.Instance().IsUsedInspector[CamIndex] == true)
            {
                lblStatus.Text = "가동";
                lblStatus.Appearance.BackColor = Color.DarkGreen;
                ioName = string.Format("OutTowerLampYellow{0}", CamIndex + 1);
                digitalIoHandler.WriteOutput(DeviceManager.Instance().PortMap[ioName], true);
            }
            else
            {
                lblStatus.Text = "비가동";
                lblStatus.Appearance.BackColor = Color.Gray;
                ioName = string.Format("OutTowerLampYellow{0}", CamIndex + 1);
                digitalIoHandler.WriteOutput(DeviceManager.Instance().PortMap[ioName], false);
            }
        }
        #endregion


        #region 대리자
        private delegate void UpdateImageDelegate(Bitmap bitmap);

        private delegate void UpdateImagePanelDelegate(InspectResult inspectResult);
        #endregion


        #region 이벤트
        private void UITimer_Tick(object sender, EventArgs e)
        {
            if (IsUpdating == false)
            {
                UIUpdate();
            }
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            var cfg = SystemConfig.Instance();
            lblResult.Text = "대기";
            lblResult.Appearance.BackColor = Color.DarkGray;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            ImagePanel.ZoomIn();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ImagePanel.ZoomOut();
        }

        private void btnZoomFit_Click(object sender, EventArgs e)
        {
            //imagePanel.ZoomFit();
            ImagePanel.ZoomRange(new RectangleF(0, 0, 2440, 2000), true);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            string ioName = string.Format("Reject{0}Out", CamIndex + 1);
            DigitalIoHandler digitalIoHandler = DeviceManager.Instance().DigitalIoHandler;

            if (MessageBox.Show("선택하신 정보가 저장됩니다", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SystemConfig.Instance().IsUsedInspector[CamIndex] = !SystemConfig.Instance().IsUsedInspector[CamIndex];
                SystemConfig.Instance().Save();

                if (SystemConfig.Instance().IsUsedInspector[CamIndex] == true)
                {
                    lblStatus.Text = "가동";
                    lblStatus.Appearance.BackColor = Color.DarkGreen;

                    ioName = string.Format("OutTowerLampYellow{0}", CamIndex + 1);
                    digitalIoHandler.WriteOutput(DeviceManager.Instance().PortMap[ioName], false);
                }
                else
                {
                    lblStatus.Text = "비가동";
                    lblStatus.Appearance.BackColor = Color.Gray;
                    ioName = string.Format("OutTowerLampYellow{0}", CamIndex + 1);
                    digitalIoHandler.WriteOutput(DeviceManager.Instance().PortMap[ioName], true);
                }
            }
        }
        #endregion


        #region 속성
        private CanvasPanel ImagePanel { get; set; } = new CanvasPanel();

        private ConcurrentQueue<InspectResult> InspectResultQueue { get; set; } = new ConcurrentQueue<InspectResult>();

        private System.Windows.Forms.Timer UITimer { get; set; } = new System.Windows.Forms.Timer();

        private bool IsUpdating { get; set; } = false;

        public int CamIndex { get; set; }
        #endregion


        #region 메서드
        public void UpdateData(Bitmap bitmap, InspectResult inspectResult)
        {
            //UpdateImage(bitmap);
            //UpdateImagePanel(inspectResult);
        }

        public void UpdateImage(Bitmap bitmap)
        {
            //if (InvokeRequired)
            //{
            //    BeginInvoke(new UpdateImageDelegate(UpdateImage), bitmap);
            //    return;
            //}
            //
            //imagePanel.UpdateImage(bitmap);
            //bitmap.Dispose();

        }

        public void UpdateImagePanel(InspectResult inspectResult)
        {
            //if (InvokeRequired)
            //{
            //    BeginInvoke(new UpdateImagePanelDelegate(UpdateImagePanel), inspectResult);
            //    return;
            //}

            //if (inOnProgress)
            //    return;
            //inOnProgress = true;

            //inspectResult.GetResult("DefectInforList", out object result);

            ////List<DefectInfor> defectInfors = result as List<DefectInfor>;
            //imagePanel.BackgroundFigures.Clear();

            //imagePanel.UpdateImage(inspectResult.Bitmap);
            ////imagePanel.Invalidate();

            //inOnProgress = false;
        }

        public void ClearFigure()
        {
            ImagePanel.BackgroundFigures = null;
            ImagePanel.Invalidate();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void DoubleBufferPanel()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void AddFigure(Figure figure)
        {
            ImagePanel.BackgroundFigures.AddFigure(figure);
        }

        public void UpdateInspectResult(InspectResult inspectResult)
        {
            //queue 구조이므로 Clone을 해준다.
            InspectResultQueue.Enqueue(inspectResult.Clone() as InspectResult);
        }

        public void UITimerStart()
        {
            UITimer.Start();
        }

        public void UITimerStop()
        {
            UITimer.Stop();
            while (InspectResultQueue.TryDequeue(out InspectResult inspectResult))
            {
                Thread.Sleep(0);
            }
        }

        private void UIUpdate()
        {
            if (!IsUpdating)
            {
                IsUpdating = true;

                while (InspectResultQueue.TryDequeue(out InspectResult inspectResult))
                {
                    var containerAlgoParam = (ContainerAlgoParam)ContainerAlgoParam.Instance();
                    ContainerAlgo_PreprocessParam containerAlgo_PreprocessParam = ((ContainerAlgoParam)ContainerAlgoParam.Instance()).ContainerAlgo_PreprocessParam;
                    ContainerAlgo_ProcessParam containerAlgo_ProcessParam = ((ContainerAlgoParam)ContainerAlgoParam.Instance()).ContainerAlgo_ProcessParam;

                    ImagePanel.BackgroundFigures.Clear();

                    var rect = new Rectangle();
                    var ellipseFigure = new EllipseFigure();

                    //rect = new Rectangle(-containerAlgo_PreprocessParam.RadIn, -containerAlgo_PreprocessParam.RadIn, containerAlgo_PreprocessParam.RadIn * 2, containerAlgo_PreprocessParam.RadIn * 2);
                    //rect.Offset(containerAlgo_ProcessParam.CenterPt.X, containerAlgo_ProcessParam.CenterPt.Y);
                    //ellipseFigure = new EllipseFigure(rect, new Pen(Color.Gray));
                    //AddFigure(ellipseFigure);

                    //rect = new Rectangle(-containerAlgo_PreprocessParam.RadOut, -containerAlgo_PreprocessParam.RadOut, containerAlgo_PreprocessParam.RadOut * 2, containerAlgo_PreprocessParam.RadOut * 2);
                    //rect.Offset(containerAlgo_ProcessParam.CenterPt.X, containerAlgo_ProcessParam.CenterPt.Y);
                    //ellipseFigure = new EllipseFigure(rect, new Pen(Color.Gray));
                    //AddFigure(ellipseFigure);

                    rect = new Rectangle(-containerAlgo_PreprocessParam.Rad, -containerAlgo_PreprocessParam.Rad, containerAlgo_PreprocessParam.Rad * 2, containerAlgo_PreprocessParam.Rad * 2);
                    rect.Offset(inspectResult.CenterPt.X, inspectResult.CenterPt.Y);
                    ellipseFigure = new EllipseFigure(rect, new Pen(Color.DarkGray));
                    AddFigure(ellipseFigure);

                    int zoneHeight = 0;
                    for (int i = containerAlgo_ProcessParam.InspectionZoneParam.Length - 1; i >= 0; --i)
                    {
                        zoneHeight += containerAlgo_ProcessParam.InspectionZoneParam[i].ZoneHeight;
                        rect = new Rectangle(
                            -(containerAlgo_PreprocessParam.Rad - zoneHeight),
                            -(containerAlgo_PreprocessParam.Rad - zoneHeight),
                            (containerAlgo_PreprocessParam.Rad - zoneHeight) * 2,
                            (containerAlgo_PreprocessParam.Rad - zoneHeight) * 2);

                        rect.Offset(inspectResult.CenterPt.X, inspectResult.CenterPt.Y);
                        ellipseFigure = new EllipseFigure(rect, new Pen(Color.DarkGray));
                        AddFigure(ellipseFigure);
                    }

                    for (int i = 0; i < containerAlgo_PreprocessParam.EdgeROI.Length; ++i)
                    {
                        //RotatedRect rotatedRect = new RotatedRect(containerAlgo_PreprocessParam.EdgeROI[i].Center, containerAlgo_PreprocessParam.EdgeROI[i].Size, containerAlgo_PreprocessParam.EdgeROI[i].Angle);
                        //RectangleFigure rectFigure = new RectangleFigure(rotatedRect, new Pen(Color.Gray));
                        //AddFigure(rectFigure);

                        var rectFigure = new RectangleFigure(containerAlgo_PreprocessParam.EdgeROI[i].MinAreaRect(), new Pen(Color.Gray));
                        AddFigure(rectFigure);
                    }

                    foreach (DefectInfor defectInfor in inspectResult.DefectInforList)
                    {
                        if (defectInfor.isDefect)
                        {
                            var rectFigure = new RectangleFigure(defectInfor.boundingBox, new Pen(Color.Red));
                            AddFigure(rectFigure);
                        }
                        else if (SystemConfig.Instance().IsShowAllDefect)
                        {
                            var rectFigure = new RectangleFigure(defectInfor.boundingBox, new Pen(Color.LightGreen));
                            AddFigure(rectFigure);
                        }
                    }

                    if (inspectResult.InspectJudgment == DynMvp.Vision.Judgment.OK)
                    {
                        lblResult.Text = "정상";
                        lblResult.Appearance.BackColor = Color.Green;
                    }
                    else
                    {
                        lblResult.Text = "불량";
                        lblResult.Appearance.BackColor = Color.Red;
                    }

                    ImagePanel.UpdateImage((Bitmap)inspectResult.CloneDrawImage());

                    inspectResult.MyDispose();
                    inspectResult = null;
                }

                IsUpdating = false;
            }
        }
        #endregion
    }
}
