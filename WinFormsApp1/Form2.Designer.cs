namespace WinFormsApp1
{
    partial class Form2
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
            colorDialog1 = new ColorDialog();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnlogout = new Button();
            button2 = new Button();
            txtbayar = new TextBox();
            txttotal = new TextBox();
            btnproses = new Button();
            groupBox2 = new GroupBox();
            txtjumlahmkn = new TextBox();
            txtjumlahmnm = new TextBox();
            txtmakanan = new TextBox();
            txtminuman = new TextBox();
            cmbminuman = new ComboBox();
            nmcjumlahmnm = new NumericUpDown();
            label7 = new Label();
            nmcjumlahmkn = new NumericUpDown();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmbmakanan = new ComboBox();
            txtkembali = new TextBox();
            txtnamakasir = new TextBox();
            label8 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcjumlahmnm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcjumlahmkn).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 550);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 20;
            label5.Text = "Kembali";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 493);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 19;
            label4.Text = "Bayar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 443);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 16;
            label3.Text = "Total";
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(192, 0, 0);
            btnlogout.Location = new Point(144, 630);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 18;
            btnlogout.Text = "logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(568, 630);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Tutup";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtbayar
            // 
            txtbayar.BackColor = Color.FromArgb(255, 128, 0);
            txtbayar.Location = new Point(528, 487);
            txtbayar.Multiline = true;
            txtbayar.Name = "txtbayar";
            txtbayar.Size = new Size(184, 37);
            txtbayar.TabIndex = 14;
            // 
            // txttotal
            // 
            txttotal.BackColor = Color.FromArgb(255, 128, 0);
            txttotal.Location = new Point(528, 435);
            txttotal.Multiline = true;
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(184, 37);
            txttotal.TabIndex = 13;
            txttotal.TextChanged += txttotal_TextChanged;
            // 
            // btnproses
            // 
            btnproses.BackColor = Color.Red;
            btnproses.Location = new Point(370, 630);
            btnproses.Name = "btnproses";
            btnproses.Size = new Size(94, 29);
            btnproses.TabIndex = 12;
            btnproses.Text = "Proses";
            btnproses.UseVisualStyleBackColor = false;
            btnproses.Click += btnproses_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtjumlahmkn);
            groupBox2.Controls.Add(txtjumlahmnm);
            groupBox2.Controls.Add(txtmakanan);
            groupBox2.Controls.Add(txtminuman);
            groupBox2.Location = new Point(456, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 358);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "harga";
            // 
            // txtjumlahmkn
            // 
            txtjumlahmkn.Location = new Point(49, 111);
            txtjumlahmkn.Multiline = true;
            txtjumlahmkn.Name = "txtjumlahmkn";
            txtjumlahmkn.Size = new Size(157, 34);
            txtjumlahmkn.TabIndex = 5;
            txtjumlahmkn.TextChanged += txtjumlahmkn_TextChanged;
            // 
            // txtjumlahmnm
            // 
            txtjumlahmnm.Location = new Point(49, 270);
            txtjumlahmnm.Multiline = true;
            txtjumlahmnm.Name = "txtjumlahmnm";
            txtjumlahmnm.Size = new Size(157, 34);
            txtjumlahmnm.TabIndex = 4;
            // 
            // txtmakanan
            // 
            txtmakanan.BackColor = Color.FromArgb(255, 128, 0);
            txtmakanan.Location = new Point(49, 37);
            txtmakanan.Multiline = true;
            txtmakanan.Name = "txtmakanan";
            txtmakanan.Size = new Size(157, 37);
            txtmakanan.TabIndex = 2;
            // 
            // txtminuman
            // 
            txtminuman.BackColor = Color.FromArgb(255, 128, 0);
            txtminuman.Location = new Point(49, 193);
            txtminuman.Multiline = true;
            txtminuman.Name = "txtminuman";
            txtminuman.Size = new Size(157, 37);
            txtminuman.TabIndex = 1;
            txtminuman.TextChanged += txtminuman_TextChanged;
            // 
            // cmbminuman
            // 
            cmbminuman.BackColor = Color.FromArgb(255, 128, 0);
            cmbminuman.FormattingEnabled = true;
            cmbminuman.Items.AddRange(new object[] { "Matcha", "Green tea", "Banana milk" });
            cmbminuman.Location = new Point(161, 193);
            cmbminuman.Name = "cmbminuman";
            cmbminuman.Size = new Size(151, 28);
            cmbminuman.TabIndex = 3;
            cmbminuman.SelectedIndexChanged += cmbminuman_SelectedIndexChanged_1;
            // 
            // nmcjumlahmnm
            // 
            nmcjumlahmnm.Location = new Point(161, 277);
            nmcjumlahmnm.Name = "nmcjumlahmnm";
            nmcjumlahmnm.Size = new Size(151, 27);
            nmcjumlahmnm.TabIndex = 9;
            nmcjumlahmnm.ValueChanged += nmcjumlahmnm_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 284);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 8;
            label7.Text = "jumlah";
            // 
            // nmcjumlahmkn
            // 
            nmcjumlahmkn.Location = new Point(161, 118);
            nmcjumlahmkn.Name = "nmcjumlahmkn";
            nmcjumlahmkn.Size = new Size(151, 27);
            nmcjumlahmkn.TabIndex = 7;
            nmcjumlahmkn.ValueChanged += nmcjumlahmkn_ValueChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 120);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 6;
            label6.Text = "jumlah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 196);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "minuman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "makanan";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nmcjumlahmnm);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nmcjumlahmkn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbminuman);
            groupBox1.Controls.Add(cmbmakanan);
            groupBox1.Location = new Point(88, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 358);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daftar menu korean food";
            // 
            // cmbmakanan
            // 
            cmbmakanan.BackColor = Color.FromArgb(255, 128, 0);
            cmbmakanan.FormattingEnabled = true;
            cmbmakanan.Items.AddRange(new object[] { "Kimbab", "Bibimbap", "Ramyeon" });
            cmbmakanan.Location = new Point(161, 37);
            cmbmakanan.Name = "cmbmakanan";
            cmbmakanan.Size = new Size(151, 28);
            cmbmakanan.TabIndex = 2;
            cmbmakanan.SelectedIndexChanged += cmbmakanan_SelectedIndexChanged_1;
            // 
            // txtkembali
            // 
            txtkembali.BackColor = Color.FromArgb(255, 128, 0);
            txtkembali.Location = new Point(528, 539);
            txtkembali.Multiline = true;
            txtkembali.Name = "txtkembali";
            txtkembali.Size = new Size(184, 37);
            txtkembali.TabIndex = 15;
            // 
            // txtnamakasir
            // 
            txtnamakasir.Location = new Point(174, 397);
            txtnamakasir.Multiline = true;
            txtnamakasir.Name = "txtnamakasir";
            txtnamakasir.Size = new Size(125, 34);
            txtnamakasir.TabIndex = 21;
            txtnamakasir.TextChanged += txtnamakasir_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(88, 400);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 22;
            label8.Text = "nama kasir";
            label8.Click += label8_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 674);
            Controls.Add(label8);
            Controls.Add(txtnamakasir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnlogout);
            Controls.Add(button2);
            Controls.Add(txtbayar);
            Controls.Add(txttotal);
            Controls.Add(btnproses);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtkembali);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmcjumlahmnm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcjumlahmkn).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnlogout;
        private Button button2;
        private TextBox txtbayar;
        private TextBox txttotal;
        private Button btnproses;
        private GroupBox groupBox2;
        private TextBox txtjumlahmnm;
        private TextBox txtmakanan;
        private TextBox txtminuman;
        private ComboBox cmbminuman;
        private NumericUpDown nmcjumlahmnm;
        private Label label7;
        private NumericUpDown nmcjumlahmkn;
        private Label label6;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbmakanan;
        private TextBox txtkembali;
        private TextBox txtjumlahmkn;
        private TextBox txtnamakasir;
        private Label label8;
    }
}