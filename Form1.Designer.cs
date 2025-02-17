namespace Bai8_Pheptinhcoban_radio_batton
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChia = new System.Windows.Forms.RadioButton();
            this.rdbNhan = new System.Windows.Forms.RadioButton();
            this.rdbTru = new System.Windows.Forms.RadioButton();
            this.rdbCong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH PHÉP TÍNH CƠ BẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NHẬP SỐ MỘT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KẾT QUẢ";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(203, 95);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(192, 20);
            this.txtSo1.TabIndex = 3;
            this.txtSo1.Text = "2,3";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(203, 211);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(192, 20);
            this.txtKQ.TabIndex = 3;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(203, 148);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(192, 20);
            this.txtSo2.TabIndex = 3;
            this.txtSo2.Text = "9,8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NHẬP SỐ HAI";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(221, 269);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(159, 33);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "TÍNH";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChia);
            this.groupBox1.Controls.Add(this.rdbNhan);
            this.groupBox1.Controls.Add(this.rdbTru);
            this.groupBox1.Controls.Add(this.rdbCong);
            this.groupBox1.Location = new System.Drawing.Point(504, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbChia
            // 
            this.rdbChia.AutoSize = true;
            this.rdbChia.Location = new System.Drawing.Point(15, 135);
            this.rdbChia.Name = "rdbChia";
            this.rdbChia.Size = new System.Drawing.Size(50, 17);
            this.rdbChia.TabIndex = 3;
            this.rdbChia.TabStop = true;
            this.rdbChia.Text = "CHIA";
            this.rdbChia.UseVisualStyleBackColor = true;
            // 
            // rdbNhan
            // 
            this.rdbNhan.AutoSize = true;
            this.rdbNhan.Location = new System.Drawing.Point(15, 100);
            this.rdbNhan.Name = "rdbNhan";
            this.rdbNhan.Size = new System.Drawing.Size(56, 17);
            this.rdbNhan.TabIndex = 2;
            this.rdbNhan.TabStop = true;
            this.rdbNhan.Text = "NHÂN";
            this.rdbNhan.UseVisualStyleBackColor = true;
            this.rdbNhan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbTru
            // 
            this.rdbTru.AutoSize = true;
            this.rdbTru.Location = new System.Drawing.Point(15, 63);
            this.rdbTru.Name = "rdbTru";
            this.rdbTru.Size = new System.Drawing.Size(48, 17);
            this.rdbTru.TabIndex = 1;
            this.rdbTru.TabStop = true;
            this.rdbTru.Text = "TRỪ";
            this.rdbTru.UseVisualStyleBackColor = true;
            // 
            // rdbCong
            // 
            this.rdbCong.AutoSize = true;
            this.rdbCong.Location = new System.Drawing.Point(15, 28);
            this.rdbCong.Name = "rdbCong";
            this.rdbCong.Size = new System.Drawing.Size(56, 17);
            this.rdbCong.TabIndex = 0;
            this.rdbCong.TabStop = true;
            this.rdbCong.Text = "CỘNG";
            this.rdbCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChia;
        private System.Windows.Forms.RadioButton rdbNhan;
        private System.Windows.Forms.RadioButton rdbTru;
        private System.Windows.Forms.RadioButton rdbCong;
    }
}

