namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpw.Text;

            // Cek username dan password
            if (user == "1" && pass == "1")
            {
                MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 kasir = new Form2();
                kasir.Show();

                // menyembunyikan form login
                this.Hide();

                kasir.FormClosed += (s, args) => this.Close();
            }
            else if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Login gagal! Username atau Password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
