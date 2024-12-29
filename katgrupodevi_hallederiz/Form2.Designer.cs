namespace katgrupodevi_hallederiz
{
    partial class Form_anaekran
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
            groupBox_hosgeldiniz = new GroupBox();
            maskedTextBox_num = new MaskedTextBox();
            label_bilgi = new Label();
            label_tel = new Label();
            textBox_adsoyad = new TextBox();
            label_adsoyad = new Label();
            label1 = new Label();
            button_sistemgiris = new Button();
            button1 = new Button();
            groupBox_hosgeldiniz.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_hosgeldiniz
            // 
            groupBox_hosgeldiniz.Controls.Add(maskedTextBox_num);
            groupBox_hosgeldiniz.Controls.Add(label_bilgi);
            groupBox_hosgeldiniz.Controls.Add(label_tel);
            groupBox_hosgeldiniz.Controls.Add(textBox_adsoyad);
            groupBox_hosgeldiniz.Controls.Add(label_adsoyad);
            groupBox_hosgeldiniz.Location = new Point(12, 12);
            groupBox_hosgeldiniz.Name = "groupBox_hosgeldiniz";
            groupBox_hosgeldiniz.Size = new Size(249, 337);
            groupBox_hosgeldiniz.TabIndex = 0;
            groupBox_hosgeldiniz.TabStop = false;
            groupBox_hosgeldiniz.Text = "Hoş Geldiniz";
            // 
            // maskedTextBox_num
            // 
            maskedTextBox_num.Location = new Point(6, 81);
            maskedTextBox_num.Mask = "(999) 000-0000";
            maskedTextBox_num.Name = "maskedTextBox_num";
            maskedTextBox_num.Size = new Size(174, 23);
            maskedTextBox_num.TabIndex = 5;
            maskedTextBox_num.TextChanged += maskedTextBox_num_TextChanged;
            // 
            // label_bilgi
            // 
            label_bilgi.AutoSize = true;
            label_bilgi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_bilgi.Location = new Point(6, 122);
            label_bilgi.Name = "label_bilgi";
            label_bilgi.Size = new Size(205, 189);
            label_bilgi.TabIndex = 4;
            label_bilgi.Text = "KAT Araç kiralama sistemine\r\nhoşgeldiniz.\r\nlütfen yukarı tarafta\r\ngerekli bilgileri girin.\r\nArdından yandaki butonlara\r\nbasıp sisteme giriş yapın.\r\n\r\n\r\n\r\n";
            // 
            // label_tel
            // 
            label_tel.AutoSize = true;
            label_tel.Location = new Point(6, 63);
            label_tel.Name = "label_tel";
            label_tel.Size = new Size(99, 15);
            label_tel.TabIndex = 2;
            label_tel.Text = "Telefon Numarası";
            // 
            // textBox_adsoyad
            // 
            textBox_adsoyad.Location = new Point(6, 37);
            textBox_adsoyad.Name = "textBox_adsoyad";
            textBox_adsoyad.Size = new Size(174, 23);
            textBox_adsoyad.TabIndex = 1;
            textBox_adsoyad.TextChanged += textBox_adsoyad_TextChanged;
            // 
            // label_adsoyad
            // 
            label_adsoyad.AutoSize = true;
            label_adsoyad.Location = new Point(6, 19);
            label_adsoyad.Name = "label_adsoyad";
            label_adsoyad.Size = new Size(60, 15);
            label_adsoyad.TabIndex = 0;
            label_adsoyad.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(430, 49);
            label1.Name = "label1";
            label1.Size = new Size(200, 126);
            label1.TabIndex = 5;
            label1.Text = "230408020 - Koray Oray\r\n230408002 - Alpay Gökyüz\r\n230408017 - Tufan Coşkun\r\n\r\n\r\n\r\n";
            // 
            // button_sistemgiris
            // 
            button_sistemgiris.Enabled = false;
            button_sistemgiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_sistemgiris.Location = new Point(415, 134);
            button_sistemgiris.Name = "button_sistemgiris";
            button_sistemgiris.Size = new Size(236, 66);
            button_sistemgiris.TabIndex = 6;
            button_sistemgiris.Text = "Sisteme Giriş Yapın\r\n";
            button_sistemgiris.UseVisualStyleBackColor = true;
            button_sistemgiris.Click += button_sistemgiris_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(444, 206);
            button1.Name = "button1";
            button1.Size = new Size(186, 43);
            button1.TabIndex = 7;
            button1.Text = "Açıklamalar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_anaekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(784, 361);
            Controls.Add(button1);
            Controls.Add(button_sistemgiris);
            Controls.Add(label1);
            Controls.Add(groupBox_hosgeldiniz);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_anaekran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BGP205_FinalProject";
            groupBox_hosgeldiniz.ResumeLayout(false);
            groupBox_hosgeldiniz.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_hosgeldiniz;
        private Label label_bilgi;
        private Label label_tel;
        private TextBox textBox_adsoyad;
        private Label label_adsoyad;
        private Label label1;
        private Button button_sistemgiris;
        private Button button1;
        private MaskedTextBox maskedTextBox_num;
    }
}