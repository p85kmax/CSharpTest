namespace GraphDialog
{
    partial class Form_UIFlicker
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
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_MainView = new System.Windows.Forms.Panel();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_TitleC = new System.Windows.Forms.Label();
            this.label_TitleL = new System.Windows.Forms.Label();
            this.label_TitleR = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_Title.Controls.Add(this.label_TitleR);
            this.panel_Title.Controls.Add(this.label_TitleL);
            this.panel_Title.Controls.Add(this.label_TitleC);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(800, 89);
            this.panel_Title.TabIndex = 0;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_Menu.Controls.Add(this.button4);
            this.panel_Menu.Controls.Add(this.button3);
            this.panel_Menu.Controls.Add(this.button2);
            this.panel_Menu.Controls.Add(this.button1);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 89);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(95, 361);
            this.panel_Menu.TabIndex = 1;
            // 
            // panel_MainView
            // 
            this.panel_MainView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainView.Location = new System.Drawing.Point(95, 89);
            this.panel_MainView.Name = "panel_MainView";
            this.panel_MainView.Size = new System.Drawing.Size(705, 361);
            this.panel_MainView.TabIndex = 3;
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.Color.Chocolate;
            this.panel_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Status.Location = new System.Drawing.Point(95, 428);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(705, 22);
            this.panel_Status.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 28);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label_TitleC
            // 
            this.label_TitleC.AutoSize = true;
            this.label_TitleC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_TitleC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TitleC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TitleC.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleC.ForeColor = System.Drawing.Color.White;
            this.label_TitleC.Location = new System.Drawing.Point(0, 0);
            this.label_TitleC.Margin = new System.Windows.Forms.Padding(30);
            this.label_TitleC.Name = "label_TitleC";
            this.label_TitleC.Padding = new System.Windows.Forms.Padding(10);
            this.label_TitleC.Size = new System.Drawing.Size(406, 95);
            this.label_TitleC.TabIndex = 0;
            this.label_TitleC.Text = "Flicker Test";
            // 
            // label_TitleL
            // 
            this.label_TitleL.AutoSize = true;
            this.label_TitleL.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_TitleL.Location = new System.Drawing.Point(0, 0);
            this.label_TitleL.Name = "label_TitleL";
            this.label_TitleL.Size = new System.Drawing.Size(38, 12);
            this.label_TitleL.TabIndex = 0;
            this.label_TitleL.Text = "label1";
            // 
            // label_TitleR
            // 
            this.label_TitleR.AutoSize = true;
            this.label_TitleR.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_TitleR.Location = new System.Drawing.Point(762, 0);
            this.label_TitleR.Name = "label_TitleR";
            this.label_TitleR.Size = new System.Drawing.Size(38, 12);
            this.label_TitleR.TabIndex = 0;
            this.label_TitleR.Text = "label1";
            // 
            // Form_UIFlicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.panel_MainView);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Title);
            this.Name = "Form_UIFlicker";
            this.Text = "Form_UIFlicker";
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_MainView;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Label label_TitleR;
        private System.Windows.Forms.Label label_TitleL;
        private System.Windows.Forms.Label label_TitleC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}