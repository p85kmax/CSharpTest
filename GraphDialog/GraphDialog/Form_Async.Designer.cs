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
            this.label_Debug = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Top
            // 
            this.label_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Top.BackColor = System.Drawing.Color.Black;
            this.label_Top.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Top.ForeColor = System.Drawing.Color.Yellow;
            this.label_Top.Location = new System.Drawing.Point(22, 18);
            this.label_Top.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Top.Name = "label_Top";
            this.label_Top.Padding = new System.Windows.Forms.Padding(6);
            this.label_Top.Size = new System.Drawing.Size(813, 90);
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
            this.button_AsyncStart.Location = new System.Drawing.Point(496, 352);
            this.button_AsyncStart.Margin = new System.Windows.Forms.Padding(6);
            this.button_AsyncStart.Name = "button_AsyncStart";
            this.button_AsyncStart.Size = new System.Drawing.Size(323, 94);
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
            this.label_Status.Location = new System.Drawing.Point(2, 598);
            this.label_Status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(854, 70);
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
            this.button1.Location = new System.Drawing.Point(496, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 94);
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
            this.label_TimeTick.Location = new System.Drawing.Point(22, 108);
            this.label_TimeTick.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_TimeTick.Name = "label_TimeTick";
            this.label_TimeTick.Size = new System.Drawing.Size(199, 70);
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
            this.button_AsyncStart2nd.Location = new System.Drawing.Point(147, 352);
            this.button_AsyncStart2nd.Margin = new System.Windows.Forms.Padding(6);
            this.button_AsyncStart2nd.Name = "button_AsyncStart2nd";
            this.button_AsyncStart2nd.Size = new System.Drawing.Size(323, 94);
            this.button_AsyncStart2nd.TabIndex = 1;
            this.button_AsyncStart2nd.Text = "Async Start 2nd";
            this.button_AsyncStart2nd.UseVisualStyleBackColor = false;
            this.button_AsyncStart2nd.Click += new System.EventHandler(this.button_AsyncStart2nd_Click);
            // 
            // label_Debug
            // 
            this.label_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Debug.BackColor = System.Drawing.Color.Sienna;
            this.label_Debug.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Debug.Location = new System.Drawing.Point(2, 512);
            this.label_Debug.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Debug.Name = "label_Debug";
            this.label_Debug.Size = new System.Drawing.Size(854, 70);
            this.label_Debug.TabIndex = 2;
            this.label_Debug.Text = "Status";
            this.label_Debug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Async
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 666);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_TimeTick);
            this.Controls.Add(this.label_Debug);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_AsyncStart2nd);
            this.Controls.Add(this.button_AsyncStart);
            this.Controls.Add(this.label_Top);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Label label_Debug;
        private System.Windows.Forms.Button button2;
    }
}