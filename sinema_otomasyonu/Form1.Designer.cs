
namespace sinema_otomasyonu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.biletiptal_btn = new System.Windows.Forms.Button();
            this.biletsat_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.salonname_lbl = new System.Windows.Forms.Label();
            this.koltukname_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boskoltuk_btn = new System.Windows.Forms.Button();
            this.bakiye_btn = new System.Windows.Forms.Button();
            this.koltukTexBox = new System.Windows.Forms.TextBox();
            this.olustur_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boskoltuk_lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.biletiptal_btn);
            this.groupBox1.Controls.Add(this.biletsat_btn);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İptali";
            // 
            // biletiptal_btn
            // 
            this.biletiptal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletiptal_btn.Location = new System.Drawing.Point(102, 75);
            this.biletiptal_btn.Name = "biletiptal_btn";
            this.biletiptal_btn.Size = new System.Drawing.Size(79, 41);
            this.biletiptal_btn.TabIndex = 2;
            this.biletiptal_btn.Text = "Bilet İptal";
            this.biletiptal_btn.UseVisualStyleBackColor = true;
            this.biletiptal_btn.Click += new System.EventHandler(this.biletiptal_btn_Click);
            // 
            // biletsat_btn
            // 
            this.biletsat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletsat_btn.Location = new System.Drawing.Point(25, 75);
            this.biletsat_btn.Name = "biletsat_btn";
            this.biletsat_btn.Size = new System.Drawing.Size(71, 41);
            this.biletsat_btn.TabIndex = 1;
            this.biletsat_btn.Text = "Bilet Sat";
            this.biletsat_btn.UseVisualStyleBackColor = true;
            this.biletsat_btn.Click += new System.EventHandler(this.biletsat_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "İndirimli";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // salonname_lbl
            // 
            this.salonname_lbl.AutoSize = true;
            this.salonname_lbl.Location = new System.Drawing.Point(12, 63);
            this.salonname_lbl.Name = "salonname_lbl";
            this.salonname_lbl.Size = new System.Drawing.Size(37, 13);
            this.salonname_lbl.TabIndex = 1;
            this.salonname_lbl.Text = "Salon:";
            // 
            // koltukname_lbl
            // 
            this.koltukname_lbl.AutoSize = true;
            this.koltukname_lbl.Location = new System.Drawing.Point(12, 95);
            this.koltukname_lbl.Name = "koltukname_lbl";
            this.koltukname_lbl.Size = new System.Drawing.Size(70, 13);
            this.koltukname_lbl.TabIndex = 2;
            this.koltukname_lbl.Text = "Koltuk Sayısı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boskoltuk_btn);
            this.groupBox2.Controls.Add(this.bakiye_btn);
            this.groupBox2.Location = new System.Drawing.Point(522, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // boskoltuk_btn
            // 
            this.boskoltuk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boskoltuk_btn.Location = new System.Drawing.Point(113, 75);
            this.boskoltuk_btn.Name = "boskoltuk_btn";
            this.boskoltuk_btn.Size = new System.Drawing.Size(88, 41);
            this.boskoltuk_btn.TabIndex = 4;
            this.boskoltuk_btn.Text = "Boş Koltuk";
            this.boskoltuk_btn.UseVisualStyleBackColor = true;
            this.boskoltuk_btn.Click += new System.EventHandler(this.boskoltuk_btn_Click);
            // 
            // bakiye_btn
            // 
            this.bakiye_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiye_btn.Location = new System.Drawing.Point(6, 75);
            this.bakiye_btn.Name = "bakiye_btn";
            this.bakiye_btn.Size = new System.Drawing.Size(78, 41);
            this.bakiye_btn.TabIndex = 3;
            this.bakiye_btn.Text = "Bakiye";
            this.bakiye_btn.UseVisualStyleBackColor = true;
            this.bakiye_btn.Click += new System.EventHandler(this.bakiye_btn_Click);
            // 
            // koltukTexBox
            // 
            this.koltukTexBox.Location = new System.Drawing.Point(93, 88);
            this.koltukTexBox.Name = "koltukTexBox";
            this.koltukTexBox.Size = new System.Drawing.Size(100, 20);
            this.koltukTexBox.TabIndex = 4;
            // 
            // olustur_btn
            // 
            this.olustur_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olustur_btn.Location = new System.Drawing.Point(522, 26);
            this.olustur_btn.Name = "olustur_btn";
            this.olustur_btn.Size = new System.Drawing.Size(244, 82);
            this.olustur_btn.TabIndex = 5;
            this.olustur_btn.Text = "Oluştur";
            this.olustur_btn.UseVisualStyleBackColor = true;
            this.olustur_btn.Click += new System.EventHandler(this.olustur_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Boş Koltuk Sayısı:";
            // 
            // boskoltuk_lbl
            // 
            this.boskoltuk_lbl.AutoSize = true;
            this.boskoltuk_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boskoltuk_lbl.Location = new System.Drawing.Point(165, 342);
            this.boskoltuk_lbl.Name = "boskoltuk_lbl";
            this.boskoltuk_lbl.Size = new System.Drawing.Size(58, 22);
            this.boskoltuk_lbl.TabIndex = 7;
            this.boskoltuk_lbl.Text = "label2";
            this.boskoltuk_lbl.Click += new System.EventHandler(this.boskoltuk_lbl_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.boskoltuk_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.olustur_btn);
            this.Controls.Add(this.koltukTexBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.koltukname_lbl);
            this.Controls.Add(this.salonname_lbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button biletiptal_btn;
        private System.Windows.Forms.Button biletsat_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label salonname_lbl;
        private System.Windows.Forms.Label koltukname_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button boskoltuk_btn;
        private System.Windows.Forms.Button bakiye_btn;
        private System.Windows.Forms.TextBox koltukTexBox;
        private System.Windows.Forms.Button olustur_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label boskoltuk_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

