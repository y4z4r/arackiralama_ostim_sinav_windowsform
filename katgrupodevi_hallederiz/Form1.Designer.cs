namespace katgrupodevi_hallederiz
{
    partial class form_yklme
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
            components = new System.ComponentModel.Container();
            groupBox_yukleme = new GroupBox();
            checkBox_hizmetsartları = new CheckBox();
            button_udevamet = new Button();
            label_yuklenior = new Label();
            progressBar_yukleme = new ProgressBar();
            timer_yukleme = new System.Windows.Forms.Timer(components);
            groupBox_yukleme.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_yukleme
            // 
            groupBox_yukleme.Controls.Add(checkBox_hizmetsartları);
            groupBox_yukleme.Controls.Add(button_udevamet);
            groupBox_yukleme.Controls.Add(label_yuklenior);
            groupBox_yukleme.Controls.Add(progressBar_yukleme);
            groupBox_yukleme.Location = new Point(12, 12);
            groupBox_yukleme.Name = "groupBox_yukleme";
            groupBox_yukleme.Size = new Size(460, 237);
            groupBox_yukleme.TabIndex = 0;
            groupBox_yukleme.TabStop = false;
            groupBox_yukleme.Text = "Yükleme Ekranı";
            // 
            // checkBox_hizmetsartları
            // 
            checkBox_hizmetsartları.AutoSize = true;
            checkBox_hizmetsartları.Location = new Point(8, 22);
            checkBox_hizmetsartları.Name = "checkBox_hizmetsartları";
            checkBox_hizmetsartları.Size = new Size(396, 49);
            checkBox_hizmetsartları.TabIndex = 3;
            checkBox_hizmetsartları.Text = "Bu kutucuğu işaretleyerek, bu uygulamanın hizmet şartlarını ve gizlilik \r\npolitakasını kabul ediyorum.\r\n\r\n";
            checkBox_hizmetsartları.UseVisualStyleBackColor = true;
            checkBox_hizmetsartları.Visible = false;
            checkBox_hizmetsartları.CheckedChanged += checkBox_hizmetsartları_CheckedChanged;
            // 
            // button_udevamet
            // 
            button_udevamet.Enabled = false;
            button_udevamet.ForeColor = SystemColors.ControlText;
            button_udevamet.Location = new Point(314, 188);
            button_udevamet.Name = "button_udevamet";
            button_udevamet.Size = new Size(146, 23);
            button_udevamet.TabIndex = 2;
            button_udevamet.Text = "Uygulamaya Devam Et...";
            button_udevamet.UseVisualStyleBackColor = true;
            button_udevamet.Visible = false;
            button_udevamet.Click += button_udevamet_Click;
            // 
            // label_yuklenior
            // 
            label_yuklenior.AutoSize = true;
            label_yuklenior.ForeColor = Color.Red;
            label_yuklenior.Location = new Point(6, 196);
            label_yuklenior.Name = "label_yuklenior";
            label_yuklenior.Size = new Size(91, 15);
            label_yuklenior.TabIndex = 1;
            label_yuklenior.Text = "Yükleniyor... %0";
            // 
            // progressBar_yukleme
            // 
            progressBar_yukleme.Location = new Point(0, 214);
            progressBar_yukleme.Name = "progressBar_yukleme";
            progressBar_yukleme.Size = new Size(460, 23);
            progressBar_yukleme.Step = 1;
            progressBar_yukleme.TabIndex = 0;
            // 
            // timer_yukleme
            // 
            timer_yukleme.Enabled = true;
            timer_yukleme.Tick += timer_yukleme_Tick;
            // 
            // form_yklme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(484, 261);
            Controls.Add(groupBox_yukleme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_yklme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += form_yklme_Load;
            groupBox_yukleme.ResumeLayout(false);
            groupBox_yukleme.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_yukleme;
        private ProgressBar progressBar_yukleme;
        private System.Windows.Forms.Timer timer_yukleme;
        private Label label_yuklenior;
        private Button button_udevamet;
        private CheckBox checkBox_hizmetsartları;
    }
}
