namespace GraphDialog
{
    partial class Form_UserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userControl_CircleProgress1 = new GraphDialog.UserControl_CircleProgress();
            this.userControl_CircleProgress2 = new GraphDialog.UserControl_CircleProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // userControl_CircleProgress1
            // 
            this.userControl_CircleProgress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.userControl_CircleProgress1.ForeColor = System.Drawing.Color.Red;
            this.userControl_CircleProgress1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userControl_CircleProgress1.Location = new System.Drawing.Point(12, 12);
            this.userControl_CircleProgress1.Name = "userControl_CircleProgress1";
            this.userControl_CircleProgress1.Size = new System.Drawing.Size(155, 179);
            this.userControl_CircleProgress1.TabIndex = 0;
            // 
            // userControl_CircleProgress2
            // 
            this.userControl_CircleProgress2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl_CircleProgress2.Location = new System.Drawing.Point(191, 12);
            this.userControl_CircleProgress2.Name = "userControl_CircleProgress2";
            this.userControl_CircleProgress2.Size = new System.Drawing.Size(155, 179);
            this.userControl_CircleProgress2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 206);
            this.Controls.Add(this.userControl_CircleProgress2);
            this.Controls.Add(this.userControl_CircleProgress1);
            this.Name = "Form_UserControl";
            this.Text = "Form_UserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_CircleProgress userControl_CircleProgress1;
        private UserControl_CircleProgress userControl_CircleProgress2;
        private System.Windows.Forms.Timer timer1;
    }
}