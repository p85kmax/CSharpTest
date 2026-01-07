using DynMvp.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContainerInspector.UI
{
    public partial class ImageDetailViewerForm : Form
    {
        #region 필드
        private CanvasPanel imagePanel = new CanvasPanel();
        private Bitmap image = null;
        private float scale = 0.5f;
        #endregion

        #region 생성자
        public ImageDetailViewerForm(Bitmap image, float scale)
        {
            InitializeComponent();

            imagePanel.Dock = DockStyle.Fill;
            imagePanel.Margin = new Padding(0);

            panelImage.Controls.Add(imagePanel);

            this.image = image;
            this.scale = scale;
            if (scale > 1)
            {
                scale = 1;
            }
        }
        #endregion

        #region 이벤트
        private void ImageDetailViewerForm_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            Size = new Size(Convert.ToInt32(width * scale), Convert.ToInt32(height * scale));

            imagePanel.UpdateImage(image);
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            imagePanel.ZoomIn();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            imagePanel.ZoomOut();
        }

        private void btnZoomFit_Click(object sender, EventArgs e)
        {
            //imagePanel.ZoomFit();
            imagePanel.ZoomRange(new RectangleF(0, 0, 2440, 2000), true);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
