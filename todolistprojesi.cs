using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=MYOLAB2-20;Database=ToDoList;Integrated Security = True");

        private List<ToDoListItem> Gorevlerim = new List<ToDoListItem>();
        private void btnYeni_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string text = txtYeniGörev.Text;
            ToDoListItem yeniGorev = new ToDoListItem()
            {
                Id = Guid.NewGuid(), 
                GorevMetni = text,
                Tamamlandi = false,
            };
            this.Gorevlerim.Add(yeniGorev);
            this.clbYapilacaklarListesi.Items.Add(yeniGorev);

            string kayit = "insert into Yapilacaklar(Görev) values (@görev)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@görev", text);
            komut.ExecuteNonQuery();                 
            baglanti.Close();
            MessageBox.Show("Yeni Göreviniz Veritabanına Eklendi.");
            
            

        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            ToDoListItem gorev = (ToDoListItem)clbYapilacaklarListesi.SelectedItem;
            gorev.GorevMetni = txtYeniGörev.Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            clbYapilacaklarListesi.Items.Remove(clbYapilacaklarListesi.SelectedItem);
            SqlCommand komut = new SqlCommand("sp_sil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@görev", txtYeniGörev.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            txtYeniGörev.Clear();
            baglanti.Close();

        }

        private void clbYapilacaklarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)
                return;
            ToDoListItem gorev = (ToDoListItem)clbYapilacaklarListesi.SelectedItem;
            txtYeniGörev.Text = gorev.GorevMetni; 
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Copy();
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Paste();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            //SqlConnection baglanti = new SqlConnection("Server=localhost;Database = kayit;Intergated Security = True");
            //SqlCommand pass = new SqlCommand();
            //baglanti.Open();
            //pass.Connection = baglanti;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("sp_Listele", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
