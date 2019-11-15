namespace GraphDialog
{
    partial class MainForm
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
            this.button_Image = new System.Windows.Forms.Button();
            this.button_Graph = new System.Windows.Forms.Button();
            this.button_GUI = new System.Windows.Forms.Button();
            this.button_RS232c = new System.Windows.Forms.Button();
            this.button_UI_Flicker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Image
            // 
            this.button_Image.BackColor = System.Drawing.Color.Black;
            this.button_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Image.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Image.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Image.Location = new System.Drawing.Point(12, 12);
            this.button_Image.Name = "button_Image";
            this.button_Image.Size = new System.Drawing.Size(95, 86);
            this.button_Image.TabIndex = 0;
            this.button_Image.Text = "Image";
            this.button_Image.UseVisualStyleBackColor = false;
            this.button_Image.Click += new System.EventHandler(this.button_Image_Click);
            // 
            // button_Graph
            // 
            this.button_Graph.BackColor = System.Drawing.Color.Black;
            this.button_Graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Graph.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Graph.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Graph.Location = new System.Drawing.Point(113, 12);
            this.button_Graph.Name = "button_Graph";
            this.button_Graph.Size = new System.Drawing.Size(95, 86);
            this.button_Graph.TabIndex = 0;
            this.button_Graph.Text = "Graph";
            this.button_Graph.UseVisualStyleBackColor = false;
            this.button_Graph.Click += new System.EventHandler(this.button_Graph_Click);
            // 
            // button_GUI
            // 
            this.button_GUI.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_GUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GUI.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_GUI.ForeColor = System.Drawing.SystemColors.Control;
            this.button_GUI.Location = new System.Drawing.Point(214, 12);
            this.button_GUI.Name = "button_GUI";
            this.button_GUI.Size = new System.Drawing.Size(95, 86);
            this.button_GUI.TabIndex = 0;
            this.button_GUI.Text = "GUI";
            this.button_GUI.UseVisualStyleBackColor = false;
            this.button_GUI.Click += new System.EventHandler(this.button_GUI_Click);
            // 
            // button_RS232c
            // 
            this.button_RS232c.BackColor = System.Drawing.Color.Black;
            this.button_RS232c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RS232c.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_RS232c.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_RS232c.Location = new System.Drawing.Point(315, 12);
            this.button_RS232c.Name = "button_RS232c";
            this.button_RS232c.Size = new System.Drawing.Size(95, 86);
            this.button_RS232c.TabIndex = 0;
            this.button_RS232c.Text = "RS232c";
            this.button_RS232c.UseVisualStyleBackColor = false;
            this.button_RS232c.Click += new System.EventHandler(this.button_RS232c_Click);
            // 
            // button_UI_Flicker
            // 
            this.button_UI_Flicker.BackColor = System.Drawing.Color.Black;
            this.button_UI_Flicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UI_Flicker.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_UI_Flicker.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_UI_Flicker.Location = new System.Drawing.Point(416, 12);
            this.button_UI_Flicker.Name = "button_UI_Flicker";
            this.button_UI_Flicker.Size = new System.Drawing.Size(95, 86);
            this.button_UI_Flicker.TabIndex = 0;
            this.button_UI_Flicker.Text = "UI Flicker";
            this.button_UI_Flicker.UseVisualStyleBackColor = false;
            this.button_UI_Flicker.Click += new System.EventHandler(this.button_UI_Flicker_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(560, 111);
            this.Controls.Add(this.button_GUI);
            this.Controls.Add(this.button_Graph);
            this.Controls.Add(this.button_UI_Flicker);
            this.Controls.Add(this.button_RS232c);
            this.Controls.Add(this.button_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Image;
        private System.Windows.Forms.Button button_Graph;
        private System.Windows.Forms.Button button_GUI;
        private System.Windows.Forms.Button button_RS232c;
        private System.Windows.Forms.Button button_UI_Flicker;
    }
}