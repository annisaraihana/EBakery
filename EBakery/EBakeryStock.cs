using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBakery
{
    public partial class EBakeryStock : Form
    {
        public EBakeryStock()
        {
            InitializeComponent();
        }

        private void btnTambahMenu_Click(object sender, EventArgs e)
        {
            InputMenuForm menuForm = new InputMenuForm();
            menuForm.ShowDialog();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "-";
            lblHarga.Text = "-";
            lblStock.Text = "-";
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            using (var db = new MenuModel())
            {
                var query = from menu in db.Menus where menu.Nama == tbCariMenu.Text select menu;
                foreach(var item in query)
                {
                    lblMenu.Text = item.Nama;
                    lblHarga.Text = item.Harga;
                    lblStock.Text = item.Stock;
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InputMenuForm menuForm = new InputMenuForm(lblMenu.Text, lblHarga.Text, lblStock.Text);
            menuForm.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            using (var db = new MenuModel())
            {
                db.Menus.RemoveRange(db.Menus.Where(item => item.Nama == lblMenu.Text));
                db.SaveChanges();
                lblMenu.Text = "-";
                lblHarga.Text = "-";
                lblStock.Text = "-";
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
            }
        }
    }
}
