
namespace Niên_Luận_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnNhap = new System.Windows.Forms.Panel();
            this.Nudtl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnXong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuddv = new System.Windows.Forms.NumericUpDown();
            this.BtnTinh = new System.Windows.Forms.Button();
            this.PnXuat = new System.Windows.Forms.FlowLayoutPanel();
            this.PnNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuddv)).BeginInit();
            this.SuspendLayout();
            // 
            // PnNhap
            // 
            this.PnNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnNhap.BackColor = System.Drawing.Color.Aqua;
            this.PnNhap.Controls.Add(this.Nudtl);
            this.PnNhap.Controls.Add(this.label2);
            this.PnNhap.Controls.Add(this.BtnXong);
            this.PnNhap.Controls.Add(this.label1);
            this.PnNhap.Controls.Add(this.Nuddv);
            this.PnNhap.Controls.Add(this.BtnTinh);
            this.PnNhap.Location = new System.Drawing.Point(-3, 0);
            this.PnNhap.Name = "PnNhap";
            this.PnNhap.Size = new System.Drawing.Size(332, 616);
            this.PnNhap.TabIndex = 0;
            // 
            // Nudtl
            // 
            this.Nudtl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nudtl.Location = new System.Drawing.Point(249, 100);
            this.Nudtl.Name = "Nudtl";
            this.Nudtl.Size = new System.Drawing.Size(78, 32);
            this.Nudtl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trọng Lượng Balo";
            // 
            // BtnXong
            // 
            this.BtnXong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnXong.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnXong.Location = new System.Drawing.Point(3, 211);
            this.BtnXong.Name = "BtnXong";
            this.BtnXong.Size = new System.Drawing.Size(326, 64);
            this.BtnXong.TabIndex = 3;
            this.BtnXong.Text = "Xong";
            this.BtnXong.UseVisualStyleBackColor = false;
            this.BtnXong.Click += new System.EventHandler(this.BtnXong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Loại Đồ Vật";
            // 
            // Nuddv
            // 
            this.Nuddv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nuddv.Location = new System.Drawing.Point(251, 30);
            this.Nuddv.Name = "Nuddv";
            this.Nuddv.Size = new System.Drawing.Size(78, 32);
            this.Nuddv.TabIndex = 2;
            // 
            // BtnTinh
            // 
            this.BtnTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTinh.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnTinh.Location = new System.Drawing.Point(3, 291);
            this.BtnTinh.Name = "BtnTinh";
            this.BtnTinh.Size = new System.Drawing.Size(326, 61);
            this.BtnTinh.TabIndex = 5;
            this.BtnTinh.Text = "Tính ";
            this.BtnTinh.UseVisualStyleBackColor = false;
            this.BtnTinh.Click += new System.EventHandler(this.BtnTinh_Click);
            // 
            // PnXuat
            // 
            this.PnXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnXuat.AutoScroll = true;
            this.PnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnXuat.Location = new System.Drawing.Point(331, 0);
            this.PnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.PnXuat.Name = "PnXuat";
            this.PnXuat.Size = new System.Drawing.Size(879, 616);
            this.PnXuat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 619);
            this.Controls.Add(this.PnXuat);
            this.Controls.Add(this.PnNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Niên Luận 1";
            this.PnNhap.ResumeLayout(false);
            this.PnNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nudtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nuddv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Nuddv;
        private System.Windows.Forms.Button BtnTinh;
        private System.Windows.Forms.Button BtnXong;
        private System.Windows.Forms.NumericUpDown Nudtl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel PnXuat;
    }
}

