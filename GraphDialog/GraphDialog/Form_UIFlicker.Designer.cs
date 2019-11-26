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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_TitleC = new System.Windows.Forms.Label();
            this.label_TitleR = new System.Windows.Forms.Label();
            this.label_TitleL = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_MainView = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.panel_Title.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel_MainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_Title.Controls.Add(this.label_TitleC);
            this.panel_Title.Controls.Add(this.label_TitleL);
            this.panel_Title.Controls.Add(this.label_TitleR);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(800, 89);
            this.panel_Title.TabIndex = 0;
            // 
            // label_TitleC
            // 
            this.label_TitleC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_TitleC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TitleC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TitleC.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleC.ForeColor = System.Drawing.Color.White;
            this.label_TitleC.Location = new System.Drawing.Point(204, 0);
            this.label_TitleC.Margin = new System.Windows.Forms.Padding(30);
            this.label_TitleC.Name = "label_TitleC";
            this.label_TitleC.Padding = new System.Windows.Forms.Padding(10);
            this.label_TitleC.Size = new System.Drawing.Size(452, 89);
            this.label_TitleC.TabIndex = 1;
            this.label_TitleC.Text = "Flicker Test";
            this.label_TitleC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TitleR
            // 
            this.label_TitleR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_TitleR.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_TitleR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TitleR.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleR.Location = new System.Drawing.Point(656, 0);
            this.label_TitleR.Name = "label_TitleR";
            this.label_TitleR.Size = new System.Drawing.Size(144, 89);
            this.label_TitleR.TabIndex = 0;
            this.label_TitleR.Text = "RIGHT";
            this.label_TitleR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TitleL
            // 
            this.label_TitleL.BackColor = System.Drawing.Color.Silver;
            this.label_TitleL.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_TitleL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TitleL.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleL.Location = new System.Drawing.Point(0, 0);
            this.label_TitleL.Name = "label_TitleL";
            this.label_TitleL.Size = new System.Drawing.Size(204, 89);
            this.label_TitleL.TabIndex = 0;
            this.label_TitleL.Text = "LEFT";
            this.label_TitleL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 28);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_MainView
            // 
            this.panel_MainView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_MainView.Controls.Add(this.dataGridView2);
            this.panel_MainView.Controls.Add(this.dataGridView1);
            this.panel_MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainView.Location = new System.Drawing.Point(95, 89);
            this.panel_MainView.Name = "panel_MainView";
            this.panel_MainView.Size = new System.Drawing.Size(705, 361);
            this.panel_MainView.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.CausesValidation = false;
            this.dataGridView2.ColumnHeadersHeight = 22;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(374, 16);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.Format = "N1";
            dataGridViewCellStyle24.NullValue = null;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowTemplate.Height = 11;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(321, 234);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column1.HeaderText = "Zone 1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column2.HeaderText = "Zone 2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column3.HeaderText = "Zone 3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column4.HeaderText = "Zone 4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column5.HeaderText = "Zone 5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column6.HeaderText = "Zone 6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(15, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(344, 234);
            this.dataGridView1.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.Form_UIFlicker_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_MainView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}