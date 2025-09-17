namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtpw = new TextBox();
            label2 = new Label();
            btnlog = new Button();
            txtuser = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtpw
            // 
            txtpw.Location = new Point(336, 204);
            txtpw.Multiline = true;
            txtpw.Name = "txtpw";
            txtpw.Size = new Size(223, 36);
            txtpw.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 207);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 13;
            label2.Text = "pasword";
            // 
            // btnlog
            // 
            btnlog.Location = new Point(348, 284);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(194, 29);
            btnlog.TabIndex = 12;
            btnlog.Text = "login";
            btnlog.UseVisualStyleBackColor = true;
            btnlog.Click += btnlog_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(336, 137);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(223, 36);
            txtuser.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 140);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 10;
            label1.Text = "username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpw);
            Controls.Add(label2);
            Controls.Add(btnlog);
            Controls.Add(txtuser);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpw;
        private Label label2;
        private Button btnlog;
        private TextBox txtuser;
        private Label label1;
    }
}
