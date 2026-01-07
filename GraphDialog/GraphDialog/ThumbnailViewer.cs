
using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GraphDialog
{
    public enum ViewerMode
    {
        WholeImage = 0, DefectImage = 1
    }

    public partial class ThumbnailViewer : UserControl
    {
        #region 생성자
        public ThumbnailViewer(ViewerMode viewerMode, bool isStack, int rowCount = 1, string Title = "Thumbnail")
        {
            InitializeComponent();

            labelTitle.Text = Title;

            this.ViewerMode = viewerMode;
            this.IsStack = isStack;

            DoubleBufferPanel();

            UITimer.Interval = 100;
            UITimer.Tick += UITimer_Tick;

            ThumbnailCount = 4;// SystemConfig.Instance().ThumnailMaxImageCount;
        }
        #endregion


        #region 이벤트
        private void ThumbnailViewer_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < ThumbnailCount; i++)
            //    flowMain.Controls.Add(CreatePictureBox());

            flowMain.FlowDirection = FlowDirection.TopDown;  //위 1,2~~~x 바닥
            flowMain.FlowDirection = FlowDirection.BottomUp;  //위 x~~2,1 바닥
        }

        private void UITimer_Tick(object sender, EventArgs e)
        {
            if (IsUpdating == false)
            {
                UIUpdate();
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            //var control = sender as PictureBox;
            //var form = new ImageDetailViewerForm(control.Tag as Bitmap, 0.75f);
            //form.ShowDialog();
        }
        #endregion


        #region 속성
        private ViewerMode ViewerMode { get; set; }

        private bool IsStack { get; set; } = false;

        private int RowCount { get; set; } = 1;

        private ConcurrentQueue<Bitmap> InspectResultQueue { get; set; } = new ConcurrentQueue<Bitmap>();

        private System.Windows.Forms.Timer UITimer { get; set; } = new System.Windows.Forms.Timer();

        private object LockObject { get; set; } = new object();

        private bool IsUpdating { get; set; } = false;

        public int ThumbnailCount { get; set; } = 5;
        #endregion


        #region 메서드
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public void DoubleBufferPanel()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        public void UpdateInspectResult(Bitmap image)
        {
            //queue 구조이므로 Clone을 해준다.
            InspectResultQueue.Enqueue(image);
        }

        public void UITimerStart()
        {
            UITimer.Start();
        }

        public void UITimerStop()
        {
            UITimer.Stop();
            while (InspectResultQueue.TryDequeue(out Bitmap image))
            {
                Thread.Sleep(0);
            }
        }

        private void UIUpdate()
        {
            if (!IsUpdating)
            {
                IsUpdating = true;

                while (InspectResultQueue.TryDequeue(out Bitmap image))
                {
                    int cnt = 0;
                    bool showAll = true;// SystemConfig.Instance().IsShowAllDefect;

                    UpdatePictureBoxImage(image);

                }

                IsUpdating = false;
            }
        }

        public void ClearControls()
        {
            flowMain.Controls.Clear();
        }

        private void UpdatePictureBoxImage(Bitmap Image)
        {
            if (flowMain.Controls.Count < ThumbnailCount)
            {
                PictureBox pictureBox = CreatePictureBox(Image);

                if (IsStack == false)
                {
                    flowMain.Controls.Clear();
                    flowMain.Controls.Add(pictureBox);
                }
                else
                {
                    if (flowMain.Controls.Count >= ThumbnailCount)
                    {
                        while (flowMain.Controls.Count >= ThumbnailCount)
                        {
                            flowMain.Controls.RemoveAt(0);
                        }
                    }
                    flowMain.Controls.Add(pictureBox);
                }
            }
            else
            {
                var pictureBox = flowMain.Controls[0] as PictureBox;
                flowMain.Controls.RemoveAt(0);
                pictureBox.Image = Image;
                pictureBox.Tag = Image;
                flowMain.Controls.Add(pictureBox);
            }
        }

        private PictureBox CreatePictureBox(Bitmap image)
        {
            int margin = 5;
            var pictureBox = new PictureBox();
            pictureBox.Size = GetPictureBoxSize(margin);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = image;
            pictureBox.Tag = image;
            pictureBox.Margin = new Padding(margin, margin, 0, margin);
            pictureBox.Click += PictureBox_Click;
            return pictureBox;
        }

        private Size GetPictureBoxSize(int margin)
        {
            int baseSize = flowMain.Height;
            int pictureBoxSize = baseSize / RowCount - margin * 2;
            return new Size(pictureBoxSize, pictureBoxSize);
        }
        #endregion

        private static int loadCount = 0;
        private void labelTitle_Click(object sender, EventArgs e)
        {

            loadCount++;
            // 
            var image =Image.FromFile(@"d:\lion.jpg"); //얘는 메모리 문제가 없네.

            RectangleF rectf = new RectangleF(0, 0, 535, 300); //rectf for My Text
            using (Graphics g = Graphics.FromImage(image))
            {
                g.DrawRectangle(new Pen(Color.Red, 2), Rectangle.Round(rectf)); 
                //g.SmoothingMode = SmoothingMode.AntiAlias;
                //g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                string str = string.Format("LoadImage\n{0}", loadCount.ToString());
                g.DrawString(loadCount.ToString(), new System.Drawing.Font("Tahoma", 64, FontStyle.Bold), Brushes.Black, rectf, sf);
            }

            Bitmap bitmap = new Bitmap(image, new Size(image.Width / 4, image.Height / 4));
            bitmap.SetResolution(128, 128);


            //Bitmap sourceImage = new Bitmap(@"D:\earth.png");
            // 사이즈가 변경된 이미지(1/2로 축소)
            //int width = sourceImage.Width / 2;
            //int height = sourceImage.Height / 2;
            //Size resize = new Size(width, height);
            //Bitmap resizeImage = new Bitmap(sourceImage, resize);

            UpdatePictureBoxImage(bitmap);
        }
    }
}
