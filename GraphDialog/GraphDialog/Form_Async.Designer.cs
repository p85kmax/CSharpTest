namespace GraphDialog
{
    partial class Form_Async
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
            this.label_Top = new System.Windows.Forms.Label();
            this.button_AsyncStart = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_TimeTick = new System.Windows.Forms.Label();
            this.button_AsyncStart2nd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Top
            // 
            this.label_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Top.BackColor = System.Drawing.Color.Black;
            this.label_Top.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Top.ForeColor = System.Drawing.Color.Yellow;
            this.label_Top.Location = new System.Drawing.Point(12, 9);
            this.label_Top.Name = "label_Top";
            this.label_Top.Padding = new System.Windows.Forms.Padding(3);
            this.label_Top.Size = new System.Drawing.Size(438, 45);
            this.label_Top.TabIndex = 0;
            this.label_Top.Text = "Async Test";
            this.label_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_AsyncStart
            // 
            this.button_AsyncStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_AsyncStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AsyncStart.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AsyncStart.ForeColor = System.Drawing.Color.Yellow;
            this.button_AsyncStart.Location = new System.Drawing.Point(267, 176);
            this.button_AsyncStart.Name = "button_AsyncStart";
            this.button_AsyncStart.Size = new System.Drawing.Size(174, 47);
            this.button_AsyncStart.TabIndex = 1;
            this.button_AsyncStart.Text = "Async Start";
            this.button_AsyncStart.UseVisualStyleBackColor = false;
            this.button_AsyncStart.Click += new System.EventHandler(this.button_AsyncStart_Click);
            // 
            // label_Status
            // 
            this.label_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Status.BackColor = System.Drawing.Color.Gray;
            this.label_Status.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(1, 299);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(460, 35);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "Status";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(267, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_TimeTick
            // 
            this.label_TimeTick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TimeTick.BackColor = System.Drawing.Color.Red;
            this.label_TimeTick.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeTick.ForeColor = System.Drawing.Color.Yellow;
            this.label_TimeTick.Location = new System.Drawing.Point(12, 54);
            this.label_TimeTick.Name = "label_TimeTick";
            this.label_TimeTick.Size = new System.Drawing.Size(107, 35);
            this.label_TimeTick.TabIndex = 2;
            this.label_TimeTick.Text = "TimeTick";
            this.label_TimeTick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_AsyncStart2nd
            // 
            this.button_AsyncStart2nd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_AsyncStart2nd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AsyncStart2nd.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AsyncStart2nd.ForeColor = System.Drawing.Color.Yellow;
            this.button_AsyncStart2nd.Location = new System.Drawing.Point(267, 229);
            this.button_AsyncStart2nd.Name = "button_AsyncStart2nd";
            this.button_AsyncStart2nd.Size = new System.Drawing.Size(174, 47);
            this.button_AsyncStart2nd.TabIndex = 1;
            this.button_AsyncStart2nd.Text = "Async Start 2nd";
            this.button_AsyncStart2nd.UseVisualStyleBackColor = false;
            this.button_AsyncStart2nd.Click += new System.EventHandler(this.button_AsyncStart2nd_Click);
            // 
            // Form_Async
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 333);
            this.Controls.Add(this.label_TimeTick);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_AsyncStart2nd);
            this.Controls.Add(this.button_AsyncStart);
            this.Controls.Add(this.label_Top);
            this.Name = "Form_Async";
            this.Text = "Form_Async";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.Button button_AsyncStart;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_TimeTick;
        private System.Windows.Forms.Button button_AsyncStart2nd;
    }
}