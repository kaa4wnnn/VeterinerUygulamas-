using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using VeterinerUygulama.Controls;
using VeterinerUygulama.Ui;

namespace VeterinerUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arayuzAyari();
        }

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=BABANıZıM\SQLEXPRESS;Initial Catalog=veterinervtb;Integrated Security=True;TrustServerCertificate=True");

        void arayuzAyari()
        {
            Font = new Font("Segoe UI", 9F);
            panelGridHost.Font = new Font("Segoe UI", 8.25F);
            panelFormHost.Font = panelGridHost.Font;
            lblHayvanAdi.Font = panelFormHost.Font;
            lblTur.Font = panelFormHost.Font;
            lblSahip.Font = panelFormHost.Font;
            checkBox1.Font = Font;
            lblSubtitle.Font = Font;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);

            textBox1.Enter += (s, e) => hostText1.SetFocused(true);
            textBox1.Leave += (s, e) => hostText1.SetFocused(false);
            textBox2.Enter += (s, e) => hostText2.SetFocused(true);
            textBox2.Leave += (s, e) => hostText2.SetFocused(false);
            textBox3.Enter += (s, e) => hostText3.SetFocused(true);
            textBox3.Leave += (s, e) => hostText3.SetFocused(false);

            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                dataGridView1,
                new object[] { true });

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = UiTheme.Surface;
            dataGridView1.GridColor = UiTheme.Border;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.ReadOnly = true;

            DataGridViewCellStyle header = new DataGridViewCellStyle();
            header.BackColor = UiTheme.GridHeader;
            header.ForeColor = UiTheme.TextMuted;
            header.Font = new Font("Segoe UI", 8.25F);
            dataGridView1.ColumnHeadersDefaultCellStyle = header;
            dataGridView1.ColumnHeadersHeight = 36;

            DataGridViewCellStyle cell = new DataGridViewCellStyle();
            cell.BackColor = UiTheme.Surface;
            cell.ForeColor = UiTheme.Text;
            cell.SelectionBackColor = UiTheme.GridSelection;
            cell.Font = new Font("Segoe UI", 9F);
            dataGridView1.DefaultCellStyle = cell;
        }

        public void listele()
        {
            baglanti.Open();

            string sorgu = "SELECT * FROM veterinertbl";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        public void ekle()
        {
            baglanti.Open();

            string sorgu = "INSERT INTO veterinertbl " +
                           "(EvcilHayvanAdi,EvcilHayvanTuru,SahibininIsmi,AsiDurumu) " +
                           "VALUES (@ad,@tur,@sahip,@asi)";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@tur", textBox2.Text);
            komut.Parameters.AddWithValue("@sahip", textBox3.Text);
            komut.Parameters.AddWithValue("@asi", checkBox1.Checked);

            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi", "ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglanti.Close();
            listele();
        }

        public void sil()
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            baglanti.Open();

            string sorgu = "DELETE FROM veterinertbl WHERE id=@id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt Silindi", "silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglanti.Close();
            listele();
        }

        public void guncelle()
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                baglanti.Open();

                string sorgu = "UPDATE veterinertbl SET " +
                               "EvcilHayvanAdi=@ad," +
                               "EvcilHayvanTuru=@tur," +
                               "SahibininIsmi=@sahip," +
                               "AsiDurumu=@asi " +
                               "WHERE id=@id";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@tur", textBox2.Text);
                komut.Parameters.AddWithValue("@sahip", textBox3.Text);
                komut.Parameters.AddWithValue("@asi", checkBox1.Checked);

                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Güncellendi", "güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Close();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guncelle();
        }
    }
}
