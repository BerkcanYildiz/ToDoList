using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<ToDoListItem> Gorevlerim = new List<ToDoListItem>();
        private void btnYeni_Click(object sender, EventArgs e)
        {
            ToDoListItem yeniGorev = new ToDoListItem()
            {
                Id = Guid.NewGuid(),
                GorevMetni = txtYeniGörev.Text,
                Tamamlandi = false,

            };
            this.Gorevlerim.Add(yeniGorev);
            this.clbYapilacaklarListesi.Items.Add(yeniGorev);
        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            ToDoListItem gorev = (ToDoListItem)clbYapilacaklarListesi.SelectedItem;
            gorev.GorevMetni = txtYeniGörev.Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            clbYapilacaklarListesi.Items.Remove(clbYapilacaklarListesi.SelectedItem);

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
    }
}
