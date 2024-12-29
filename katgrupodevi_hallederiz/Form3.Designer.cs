namespace katgrupodevi_hallederiz
{
    partial class Form_talimat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_talimat));
            label_talimat = new Label();
            richTextBox_talimat = new RichTextBox();
            SuspendLayout();
            // 
            // label_talimat
            // 
            label_talimat.AutoSize = true;
            label_talimat.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label_talimat.Location = new Point(12, 9);
            label_talimat.Name = "label_talimat";
            label_talimat.Size = new Size(164, 37);
            label_talimat.TabIndex = 0;
            label_talimat.Text = "Açıklamalar";
            // 
            // richTextBox_talimat
            // 
            richTextBox_talimat.Location = new Point(12, 65);
            richTextBox_talimat.Name = "richTextBox_talimat";
            richTextBox_talimat.Size = new Size(360, 284);
            richTextBox_talimat.TabIndex = 1;
            richTextBox_talimat.Text = resources.GetString("richTextBox_talimat.Text");
            richTextBox_talimat.WordWrap = false;
            // 
            // Form_talimat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(384, 361);
            Controls.Add(richTextBox_talimat);
            Controls.Add(label_talimat);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_talimat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Talimatlar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_talimat;
        private RichTextBox richTextBox_talimat;
    }
}