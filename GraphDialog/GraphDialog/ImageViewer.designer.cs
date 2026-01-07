namespace ContainerInspector.UI
{
    partial class ImageViewer
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblStatus = new Infragistics.Win.Misc.UltraLabel();
            this.btnZoomFit = new Infragistics.Win.Misc.UltraButton();
            this.btnZoomOut = new Infragistics.Win.Misc.UltraButton();
            this.btnZoomIn = new Infragistics.Win.Misc.UltraButton();
            this.lblViewerTitle = new Infragistics.Win.Misc.UltraLabel();
            this.lblResult = new Infragistics.Win.Misc.UltraLabel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.tableMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.panelMenu, 0, 0);
            this.tableMain.Controls.Add(this.panelImage, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(893, 545);
            this.tableMain.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.lblStatus);
            this.panelMenu.Controls.Add(this.btnZoomFit);
            this.panelMenu.Controls.Add(this.btnZoomOut);
            this.panelMenu.Controls.Add(this.btnZoomIn);
            this.panelMenu.Controls.Add(this.lblViewerTitle);
            this.panelMenu.Controls.Add(this.lblResult);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(893, 40);
            this.panelMenu.TabIndex = 0;
            // 
            // lblStatus
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            appearance1.ForeColor = System.Drawing.Color.White;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.lblStatus.Appearance = appearance1;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Location = new System.Drawing.Point(647, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 38);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "상태";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnZoomFit
            // 
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.btnZoomFit.Appearance = appearance2;
            this.btnZoomFit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZoomFit.ImageSize = new System.Drawing.Size(32, 32);
            this.btnZoomFit.Location = new System.Drawing.Point(226, 0);
            this.btnZoomFit.Name = "btnZoomFit";
            this.btnZoomFit.Size = new System.Drawing.Size(68, 38);
            this.btnZoomFit.TabIndex = 13;
            this.btnZoomFit.Text = "맞춤";
            this.btnZoomFit.Click += new System.EventHandler(this.btnZoomFit_Click);
            // 
            // btnZoomOut
            // 
            appearance3.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance3.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.btnZoomOut.Appearance = appearance3;
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZoomOut.ImageSize = new System.Drawing.Size(32, 32);
            this.btnZoomOut.Location = new System.Drawing.Point(158, 0);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(68, 38);
            this.btnZoomOut.TabIndex = 12;
            this.btnZoomOut.Text = "축소";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            appearance4.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance4.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.btnZoomIn.Appearance = appearance4;
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZoomIn.ImageSize = new System.Drawing.Size(32, 32);
            this.btnZoomIn.Location = new System.Drawing.Point(90, 0);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(68, 38);
            this.btnZoomIn.TabIndex = 11;
            this.btnZoomIn.Text = "확대";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // lblViewerTitle
            // 
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            appearance5.ForeColor = System.Drawing.Color.White;
            appearance5.TextHAlignAsString = "Center";
            appearance5.TextVAlignAsString = "Middle";
            this.lblViewerTitle.Appearance = appearance5;
            this.lblViewerTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblViewerTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblViewerTitle.Location = new System.Drawing.Point(0, 0);
            this.lblViewerTitle.Name = "lblViewerTitle";
            this.lblViewerTitle.Size = new System.Drawing.Size(90, 38);
            this.lblViewerTitle.TabIndex = 15;
            this.lblViewerTitle.Text = "Title";
            // 
            // lblResult
            // 
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            appearance6.ForeColor = System.Drawing.Color.White;
            appearance6.TextHAlignAsString = "Center";
            appearance6.TextVAlignAsString = "Middle";
            this.lblResult.Appearance = appearance6;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(767, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(124, 38);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "결과";
            // 
            // panelImage
            // 
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(0, 43);
            this.panelImage.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(893, 502);
            this.panelImage.TabIndex = 1;
            // 
            // ImageViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImageViewer";
            this.Size = new System.Drawing.Size(893, 545);
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            this.tableMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panelMenu;
        private Infragistics.Win.Misc.UltraButton btnZoomFit;
        private Infragistics.Win.Misc.UltraButton btnZoomOut;
        private Infragistics.Win.Misc.UltraButton btnZoomIn;
        private Infragistics.Win.Misc.UltraLabel lblViewerTitle;
        private Infragistics.Win.Misc.UltraLabel lblResult;
        private System.Windows.Forms.Panel panelImage;
        private Infragistics.Win.Misc.UltraLabel lblStatus;
    }
}
