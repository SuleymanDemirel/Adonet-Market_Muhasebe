using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       ProductDal _productDal = new ProductDal();
        CerezDal _cerezDal = new CerezDal();
        GıdaDal _gıdaDal = new GıdaDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            

        }
        
        public void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
            dgwCerezs.DataSource = _cerezDal.GetAllCerez();
            dgwGıdas.DataSource = _gıdaDal.GetAllGıda();
           
           

        }
        
        public static void LoadProducts2()
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (rdbSigara.Checked == true)
            {
                _productDal.Add(new Product
                {
                    Ürün = tbxÜrün.Text,

                    Adet = Convert.ToInt32(tbxAdet.Text),
                    Fiyat = Convert.ToDouble(tbxFiyat.Text)

                });



                MessageBox.Show("Ürün Eklendi.");
                LoadProducts();
            }
            if (rdbGıda.Checked == true)
            {
                _gıdaDal.Add(new Gıda
                {
                    Ürün = tbxÜrün.Text,

                    Adet = Convert.ToInt32(tbxAdet.Text),
                    Fiyat = Convert.ToDouble(tbxFiyat.Text)

                });

                MessageBox.Show("Ürün Eklendi.");
                LoadProducts();

            }
            if (rdbÇerez.Checked == true)
            {
                _cerezDal.Add(new Cerez
                {
                    Ürün = tbxÜrün.Text,

                    Adet = Convert.ToInt32(tbxAdet.Text),
                    Fiyat = Convert.ToDouble(tbxFiyat.Text)

                });

                MessageBox.Show("Ürün Eklendi.");
                LoadProducts();
            }
           
            
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxÜrünUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxFiyatUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxAdetUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id =  Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Ürün = tbxÜrünUpdate.Text,
                Fiyat = Convert.ToDouble(tbxFiyatUpdate.Text),
                Adet = Convert.ToInt32(tbxAdetUpdate.Text)

            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Güncellendi.");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Silindi");


        }

        private void btnGıdaGüncelle_Click(object sender, EventArgs e)
        {
            Cerez cerez = new Cerez
            {
                Id = Convert.ToInt32(dgwCerezs.CurrentRow.Cells[0].Value),
                Ürün = tbxÜrünCerezUpdate.Text,
                Fiyat = Convert.ToDouble(tbxFiyatCerezUpdate.Text),
                Adet = Convert.ToInt32(tbxAdetCerezUpdate.Text)

            };
            _cerezDal.Update(cerez);
            LoadProducts();
            MessageBox.Show("Güncellendi.");
        }

        private void btnGıdaSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwCerezs.CurrentRow.Cells[0].Value);
            _cerezDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Silindi");
        }

        private void dgwCerez_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxÜrünCerezUpdate.Text = dgwCerezs.CurrentRow.Cells[1].Value.ToString();
            tbxFiyatCerezUpdate.Text = dgwCerezs.CurrentRow.Cells[2].Value.ToString();
            tbxAdetCerezUpdate.Text = dgwCerezs.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGıdaGüncelle_Click_1(object sender, EventArgs e)
        {
            Gıda gıda = new Gıda
            {
                Id = Convert.ToInt32(dgwGıdas.CurrentRow.Cells[0].Value),
                Ürün = tbxÜrünGıdaUpdate.Text,
                Fiyat = Convert.ToDouble(tbxFiyatGıdaUpdate.Text),
                Adet = Convert.ToInt32(tbxAdetGıdaUpdate.Text)

            };
            _gıdaDal.Update(gıda);
            LoadProducts();
            MessageBox.Show("Güncellendi.");
        }

        private void btnGıdaSil_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwGıdas.CurrentRow.Cells[0].Value);
            _gıdaDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Silindi");
        }

        private void dgwGıdas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxÜrünGıdaUpdate.Text = dgwGıdas.CurrentRow.Cells[1].Value.ToString();
            tbxFiyatGıdaUpdate.Text = dgwGıdas.CurrentRow.Cells[2].Value.ToString();
            tbxAdetGıdaUpdate.Text = dgwGıdas.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
             frm.dgw_Sigaralar.DataSource = _productDal.GetAll();
            frm.dgw_Çerezler.DataSource = _cerezDal.GetAllCerez();
            frm.dgw_Gıdalar.DataSource = _gıdaDal.GetAllGıda();
            frm.Show();
        }
    }
}
