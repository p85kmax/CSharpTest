namespace GraphDialog
{
    partial class Form_Files
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button_Path = new System.Windows.Forms.Button();
            this.button_FileNameChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1, -1);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(416, 428);
            this.treeView1.TabIndex = 0;
            // 
            // button_Path
            // 
            this.button_Path.Location = new System.Drawing.Point(433, 12);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(75, 28);
            this.button_Path.TabIndex = 1;
            this.button_Path.Text = "Path";
            this.button_Path.UseVisualStyleBackColor = true;
            this.button_Path.Click += new System.EventHandler(this.button_Path_Click);
            // 
            // button_FileNameChange
            // 
            this.button_FileNameChange.Location = new System.Drawing.Point(423, 85);
            this.button_FileNameChange.Name = "button_FileNameChange";
            this.button_FileNameChange.Size = new System.Drawing.Size(84, 35);
            this.button_FileNameChange.TabIndex = 2;
            this.button_FileNameChange.Text = "fileName";
            this.button_FileNameChange.UseVisualStyleBackColor = true;
            this.button_FileNameChange.Click += new System.EventHandler(this.button_FileNameChange_Click);
            // 
            // Form_Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 427);
            this.Controls.Add(this.button_FileNameChange);
            this.Controls.Add(this.button_Path);
            this.Controls.Add(this.treeView1);
            this.Name = "Form_Files";
            this.Text = "Form_Files";
            this.Load += new System.EventHandler(this.Form_Files_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button_Path;
        private System.Windows.Forms.Button button_FileNameChange;
    }
}