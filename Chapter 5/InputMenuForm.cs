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
    public partial class InputMenuForm : Form
    {
        Menu menu;
        public enum Mode {Insert, Edit}
        Mode mode;
        public InputMenuForm()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnAksi.Text = "Tambah";
        }

        public InputMenuForm(string nama, string harga, string stock)
        {
            InitializeComponent();
            mode = Mode.Edit;
            menu = new Menu
            {
                Nama = nama,
                Harga = harga,
                Stock = stock

            };
            tbNama.Text = nama;
            tbHarga.Text = harga;
            tbStock.Text = stock;
            btnAksi.Text = "Perbarui";
        }

        private void TambahMenu()
        {
            if(tbNama.Text != "" && tbHarga.Text != "" && tbStock.Text != "")
            {
                using (var db = new MenuModel())
                {
                    Menu newMenu = new Menu
                    {
                        Nama = tbNama.Text,
                        Harga = tbHarga.Text,
                        Stock = tbStock.Text,
                    };
                    db.Menus.Add(newMenu);
                    db.SaveChanges();
                    MessageBox.Show("Menu berhasil ditambahkan");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Data yang dimasukkan belum lengkap");
            }
        }

        private void EditMenu()
        {
            using (var db = new MenuModel())
            {
                var result = db.Menus.SingleOrDefault(m => m.Nama == menu.Nama);
                if (result != null)
                {
                    if (tbNama.Text != "" && tbHarga.Text != "" && tbStock.Text != "")
                    {
                        result.Nama = tbNama.Text;
                        result.Harga = tbHarga.Text;
                        result.Stock = tbStock.Text;
                        db.SaveChanges();
                        MessageBox.Show("Menu berhasil diperbarui");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Detail menu yang dimasukkan belum lengkap");
                    }
                }
            }
        }

        private void btnAksi_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                TambahMenu();
            else if (mode == Mode.Edit)
                EditMenu();
        }
    }
}
