namespace katgrupodevi_hallederiz
{
    public partial class form_yklme : Form
    {
        public form_yklme()
        {
            InitializeComponent();
        }

        int sure = 0;
        private void form_yklme_Load(object sender, EventArgs e)
        {
            progressBar_yukleme.Value = 0;
            sure = 0;
            label_yuklenior.Text = "Yükleniyor... %0";
            button_udevamet.Visible = false;
            checkBox_hizmetsartlarý.Visible = false;
        }
        private void timer_yukleme_Tick(object sender, EventArgs e)
        {
            progressBar_yukleme.Increment(1);
            label_yuklenior.Text = "Yükleniyor... %" + progressBar_yukleme.Value;

            if (progressBar_yukleme.Value >= 100)
            {
                label_yuklenior.Text = "Yükleme Baþarýlý, lütfen saðdaki butona týklayýn!";
                label_yuklenior.ForeColor = Color.Green;
                button_udevamet.Visible = true;
                checkBox_hizmetsartlarý.Visible = true;
                timer_yukleme.Stop();
                UpdateButtonState();
            }
        }

        private void checkBox_hizmetsartlarý_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (checkBox_hizmetsartlarý.Checked)
            {
                button_udevamet.ForeColor = Color.Lime;
                button_udevamet.Enabled = true;
            }
            else
            {
                button_udevamet.ForeColor = Color.Gray;
                button_udevamet.Enabled = false;
            }
        }

        private void button_udevamet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_anaekran Form_Anaekran = new Form_anaekran();
            Form_Anaekran.Show();
            Form_Anaekran.FormClosed += (s, args) => Application.Exit();
        }
    }
}
