namespace BÀI_TÍNH_ĐIỂM_CSharp
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
            this.lblten = new System.Windows.Forms.Label();
            this.lbltoan = new System.Windows.Forms.Label();
            this.lblvan = new System.Windows.Forms.Label();
            this.lbltrungbinh = new System.Windows.Forms.Label();
            this.lblxeploai = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.txttrungbinh = new System.Windows.Forms.TextBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.btntinhtrungbinh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Location = new System.Drawing.Point(73, 79);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(42, 23);
            this.lblten.TabIndex = 0;
            this.lblten.Text = "Tên";
            this.lblten.Click += new System.EventHandler(this.lblten_Click);
            // 
            // lbltoan
            // 
            this.lbltoan.AutoSize = true;
            this.lbltoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoan.Location = new System.Drawing.Point(72, 130);
            this.lbltoan.Name = "lbltoan";
            this.lbltoan.Size = new System.Drawing.Size(54, 24);
            this.lbltoan.TabIndex = 1;
            this.lbltoan.Text = "Toán";
            // 
            // lblvan
            // 
            this.lblvan.AllowDrop = true;
            this.lblvan.AutoSize = true;
            this.lblvan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvan.Location = new System.Drawing.Point(71, 182);
            this.lblvan.Name = "lblvan";
            this.lblvan.Size = new System.Drawing.Size(40, 23);
            this.lblvan.TabIndex = 2;
            this.lblvan.Text = "văn";
            // 
            // lbltrungbinh
            // 
            this.lbltrungbinh.AutoSize = true;
            this.lbltrungbinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrungbinh.Location = new System.Drawing.Point(72, 235);
            this.lbltrungbinh.Name = "lbltrungbinh";
            this.lbltrungbinh.Size = new System.Drawing.Size(104, 23);
            this.lbltrungbinh.TabIndex = 3;
            this.lbltrungbinh.Text = "Trung bình";
            // 
            // lblxeploai
            // 
            this.lblxeploai.AutoSize = true;
            this.lblxeploai.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxeploai.Location = new System.Drawing.Point(71, 285);
            this.lblxeploai.Name = "lblxeploai";
            this.lblxeploai.Size = new System.Drawing.Size(76, 23);
            this.lblxeploai.TabIndex = 4;
            this.lblxeploai.Text = "Xếp loại";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(219, 79);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 5;
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(219, 130);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 20);
            this.txttoan.TabIndex = 6;
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(219, 182);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 20);
            this.txtvan.TabIndex = 7;
            // 
            // txttrungbinh
            // 
            this.txttrungbinh.Location = new System.Drawing.Point(219, 235);
            this.txttrungbinh.Name = "txttrungbinh";
            this.txttrungbinh.Size = new System.Drawing.Size(100, 20);
            this.txttrungbinh.TabIndex = 8;
            this.txttrungbinh.TextChanged += new System.EventHandler(this.txttrungbinh_TextChanged);
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(219, 282);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(100, 20);
            this.txtxeploai.TabIndex = 9;
            // 
            // btntinhtrungbinh
            // 
            this.btntinhtrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhtrungbinh.Location = new System.Drawing.Point(232, 369);
            this.btntinhtrungbinh.Name = "btntinhtrungbinh";
            this.btntinhtrungbinh.Size = new System.Drawing.Size(118, 24);
            this.btntinhtrungbinh.TabIndex = 10;
            this.btntinhtrungbinh.Text = "Tình Trung Bình";
            this.btntinhtrungbinh.UseVisualStyleBackColor = true;
            this.btntinhtrungbinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tính điểm";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(406, 372);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(54, 21);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 687);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btntinhtrungbinh);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.txttrungbinh);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblxeploai);
            this.Controls.Add(this.lbltrungbinh);
            this.Controls.Add(this.lblvan);
            this.Controls.Add(this.lbltoan);
            this.Controls.Add(this.lblten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lbltoan;
        private System.Windows.Forms.Label lblvan;
        private System.Windows.Forms.Label lbltrungbinh;
        private System.Windows.Forms.Label lblxeploai;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.TextBox txttrungbinh;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Button btntinhtrungbinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
    }
}

