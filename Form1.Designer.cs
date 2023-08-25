namespace _01BASIC
{
    partial class winform
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
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2"});
            this.PortNumber.Location = new System.Drawing.Point(27, 40);
            this.PortNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(114, 23);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndex = 0;
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(172, 40);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(110, 23);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(31, 302);
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(251, 25);
            this.textArea.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "LED_01 On";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "LED_01 OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "LED_02 ON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 69);
            this.button4.TabIndex = 3;
            this.button4.Text = "LED_02 OFF";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 480);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.conn_btn);
            this.Controls.Add(this.PortNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "winform";
            this.Text = "WINFORMTEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

