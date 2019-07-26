namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1_Connect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_InsertDB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_test = new System.Windows.Forms.Button();
            this.button1_setEvent = new System.Windows.Forms.Button();
            this.button_log4net = new System.Windows.Forms.Button();
            this.BtnConsole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_Connect
            // 
            this.button1_Connect.Location = new System.Drawing.Point(51, 28);
            this.button1_Connect.Name = "button1_Connect";
            this.button1_Connect.Size = new System.Drawing.Size(106, 44);
            this.button1_Connect.TabIndex = 0;
            this.button1_Connect.Text = "Conect";
            this.button1_Connect.UseVisualStyleBackColor = true;
            this.button1_Connect.Click += new System.EventHandler(this.Button1_Connect);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(51, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 112);
            this.listBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(275, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Publish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(51, 78);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(106, 32);
            this.button_Disconnect.TabIndex = 0;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect);
            // 
            // button_InsertDB
            // 
            this.button_InsertDB.Location = new System.Drawing.Point(51, 306);
            this.button_InsertDB.Name = "button_InsertDB";
            this.button_InsertDB.Size = new System.Drawing.Size(195, 37);
            this.button_InsertDB.TabIndex = 4;
            this.button_InsertDB.Text = "button_insertDB";
            this.button_InsertDB.UseVisualStyleBackColor = true;
            this.button_InsertDB.Click += new System.EventHandler(this.button_InsertDB_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(23, 32);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(67, 30);
            this.startbtn.TabIndex = 5;
            this.startbtn.Text = "start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(23, 81);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(67, 30);
            this.stopbtn.TabIndex = 5;
            this.stopbtn.Text = "stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopbtn);
            this.groupBox1.Controls.Add(this.startbtn);
            this.groupBox1.Location = new System.Drawing.Point(482, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1_test
            // 
            this.button1_test.Location = new System.Drawing.Point(476, 212);
            this.button1_test.Name = "button1_test";
            this.button1_test.Size = new System.Drawing.Size(111, 53);
            this.button1_test.TabIndex = 7;
            this.button1_test.Text = "button1_test";
            this.button1_test.UseVisualStyleBackColor = true;
            this.button1_test.Click += new System.EventHandler(this.button1_test_Click);
            // 
            // button1_setEvent
            // 
            this.button1_setEvent.Location = new System.Drawing.Point(429, 303);
            this.button1_setEvent.Name = "button1_setEvent";
            this.button1_setEvent.Size = new System.Drawing.Size(76, 43);
            this.button1_setEvent.TabIndex = 8;
            this.button1_setEvent.Text = "Set Evnet";
            this.button1_setEvent.UseVisualStyleBackColor = true;
            this.button1_setEvent.Click += new System.EventHandler(this.button1_setEvent_Click);
            // 
            // button_log4net
            // 
            this.button_log4net.Location = new System.Drawing.Point(259, 306);
            this.button_log4net.Name = "button_log4net";
            this.button_log4net.Size = new System.Drawing.Size(164, 38);
            this.button_log4net.TabIndex = 9;
            this.button_log4net.Text = "log4net";
            this.button_log4net.UseVisualStyleBackColor = true;
            this.button_log4net.Click += new System.EventHandler(this.button_log4net_Click);
            // 
            // BtnConsole
            // 
            this.BtnConsole.Location = new System.Drawing.Point(509, 303);
            this.BtnConsole.Name = "BtnConsole";
            this.BtnConsole.Size = new System.Drawing.Size(95, 40);
            this.BtnConsole.TabIndex = 10;
            this.BtnConsole.Text = "console";
            this.BtnConsole.UseVisualStyleBackColor = true;
            this.BtnConsole.Click += new System.EventHandler(this.BtnConsole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 413);
            this.Controls.Add(this.BtnConsole);
            this.Controls.Add(this.button_log4net);
            this.Controls.Add(this.button1_setEvent);
            this.Controls.Add(this.button1_test);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_InsertDB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button1_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Connect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_InsertDB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1_test;
        private System.Windows.Forms.Button button1_setEvent;
        private System.Windows.Forms.Button button_log4net;
        private System.Windows.Forms.Button BtnConsole;
    }
}

