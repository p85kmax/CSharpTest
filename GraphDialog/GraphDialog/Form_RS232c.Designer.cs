namespace GraphDialog
{
    partial class Form_RS232c
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
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.comboBox_Com = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkBox_RTS = new System.Windows.Forms.CheckBox();
            this.checkBox_DTR = new System.Windows.Forms.CheckBox();
            this.label_CTS = new System.Windows.Forms.Label();
            this.label_DSR = new System.Windows.Forms.Label();
            this.label_RI = new System.Windows.Forms.Label();
            this.label_DCD = new System.Windows.Forms.Label();
            this.label_Break = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(12, 38);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(72, 29);
            this.button_Open.TabIndex = 0;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 70);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(72, 27);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // comboBox_Com
            // 
            this.comboBox_Com.FormattingEnabled = true;
            this.comboBox_Com.Location = new System.Drawing.Point(12, 12);
            this.comboBox_Com.Name = "comboBox_Com";
            this.comboBox_Com.Size = new System.Drawing.Size(72, 20);
            this.comboBox_Com.TabIndex = 2;
            // 
            // checkBox_RTS
            // 
            this.checkBox_RTS.AutoSize = true;
            this.checkBox_RTS.BackColor = System.Drawing.Color.Gray;
            this.checkBox_RTS.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_RTS.ForeColor = System.Drawing.Color.White;
            this.checkBox_RTS.Location = new System.Drawing.Point(12, 124);
            this.checkBox_RTS.Name = "checkBox_RTS";
            this.checkBox_RTS.Size = new System.Drawing.Size(69, 25);
            this.checkBox_RTS.TabIndex = 3;
            this.checkBox_RTS.Text = "RTS";
            this.checkBox_RTS.UseVisualStyleBackColor = false;
            this.checkBox_RTS.CheckedChanged += new System.EventHandler(this.checkBox_RTS_CheckedChanged);
            // 
            // checkBox_DTR
            // 
            this.checkBox_DTR.AutoSize = true;
            this.checkBox_DTR.BackColor = System.Drawing.Color.Gray;
            this.checkBox_DTR.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_DTR.ForeColor = System.Drawing.Color.White;
            this.checkBox_DTR.Location = new System.Drawing.Point(98, 124);
            this.checkBox_DTR.Name = "checkBox_DTR";
            this.checkBox_DTR.Size = new System.Drawing.Size(69, 25);
            this.checkBox_DTR.TabIndex = 3;
            this.checkBox_DTR.Text = "DTR";
            this.checkBox_DTR.UseVisualStyleBackColor = false;
            this.checkBox_DTR.CheckedChanged += new System.EventHandler(this.checkBox_DTR_CheckedChanged);
            // 
            // label_CTS
            // 
            this.label_CTS.AutoSize = true;
            this.label_CTS.BackColor = System.Drawing.Color.Gray;
            this.label_CTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CTS.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_CTS.ForeColor = System.Drawing.Color.White;
            this.label_CTS.Location = new System.Drawing.Point(173, 126);
            this.label_CTS.Name = "label_CTS";
            this.label_CTS.Size = new System.Drawing.Size(53, 23);
            this.label_CTS.TabIndex = 4;
            this.label_CTS.Text = "CTS";
            // 
            // label_DSR
            // 
            this.label_DSR.AutoSize = true;
            this.label_DSR.BackColor = System.Drawing.Color.Gray;
            this.label_DSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_DSR.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_DSR.ForeColor = System.Drawing.Color.White;
            this.label_DSR.Location = new System.Drawing.Point(242, 126);
            this.label_DSR.Name = "label_DSR";
            this.label_DSR.Size = new System.Drawing.Size(53, 23);
            this.label_DSR.TabIndex = 4;
            this.label_DSR.Text = "DSR";
            // 
            // label_RI
            // 
            this.label_RI.AutoSize = true;
            this.label_RI.BackColor = System.Drawing.Color.Gray;
            this.label_RI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RI.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_RI.ForeColor = System.Drawing.Color.White;
            this.label_RI.Location = new System.Drawing.Point(308, 126);
            this.label_RI.Name = "label_RI";
            this.label_RI.Size = new System.Drawing.Size(29, 23);
            this.label_RI.TabIndex = 4;
            this.label_RI.Text = "RI";
            // 
            // label_DCD
            // 
            this.label_DCD.AutoSize = true;
            this.label_DCD.BackColor = System.Drawing.Color.Gray;
            this.label_DCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_DCD.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_DCD.ForeColor = System.Drawing.Color.White;
            this.label_DCD.Location = new System.Drawing.Point(353, 126);
            this.label_DCD.Name = "label_DCD";
            this.label_DCD.Size = new System.Drawing.Size(54, 23);
            this.label_DCD.TabIndex = 4;
            this.label_DCD.Text = "DCD";
            // 
            // label_Break
            // 
            this.label_Break.AutoSize = true;
            this.label_Break.BackColor = System.Drawing.Color.Gray;
            this.label_Break.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Break.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Break.ForeColor = System.Drawing.Color.White;
            this.label_Break.Location = new System.Drawing.Point(413, 126);
            this.label_Break.Name = "label_Break";
            this.label_Break.Size = new System.Drawing.Size(64, 23);
            this.label_Break.TabIndex = 4;
            this.label_Break.Text = "Break";
            // 
            // Form_RS232c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 160);
            this.Controls.Add(this.label_Break);
            this.Controls.Add(this.label_DCD);
            this.Controls.Add(this.label_RI);
            this.Controls.Add(this.label_DSR);
            this.Controls.Add(this.label_CTS);
            this.Controls.Add(this.checkBox_DTR);
            this.Controls.Add(this.checkBox_RTS);
            this.Controls.Add(this.comboBox_Com);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Open);
            this.Name = "Form_RS232c";
            this.Text = "Form_RS232c";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_RS232c_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.ComboBox comboBox_Com;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBox_RTS;
        private System.Windows.Forms.CheckBox checkBox_DTR;
        private System.Windows.Forms.Label label_DCD;
        private System.Windows.Forms.Label label_RI;
        private System.Windows.Forms.Label label_DSR;
        private System.Windows.Forms.Label label_CTS;
        private System.Windows.Forms.Label label_Break;
    }
}