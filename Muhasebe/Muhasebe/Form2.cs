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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgw_Hesaplar.AllowUserToAddRows = false;
            dgwhesaplarcerezler.AllowUserToAddRows = false;
            dgwhesaplargıda.AllowUserToAddRows = false;




            //datagridview2 Sütunları oluştur
            dgw_Hesaplar.ColumnCount = 4;
            dgw_Hesaplar.Columns[0].Name = "Id";
            dgw_Hesaplar.Columns[1].Name = "Ürün";
            dgw_Hesaplar.Columns[2].Name = "Fiyat";
            dgw_Hesaplar.Columns[3].Name = "Adet";


            dgwhesaplarcerezler.ColumnCount = 4;
            dgwhesaplarcerezler.Columns[0].Name = "Id";
            dgwhesaplarcerezler.Columns[1].Name = "Ürün";
            dgwhesaplarcerezler.Columns[2].Name = "Fiyat";
            dgwhesaplarcerezler.Columns[3].Name = "Adet";

            dgwhesaplargıda.ColumnCount = 4;
            dgwhesaplargıda.Columns[0].Name = "Id";
            dgwhesaplargıda.Columns[1].Name = "Ürün";
            dgwhesaplargıda.Columns[2].Name = "Fiyat";
            dgwhesaplargıda.Columns[3].Name = "Adet";
        }

        private void dgw_Sigaralar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbxÜrünUpdate.Text = dgw_Sigaralar.CurrentRow.Cells[1].Value.ToString();
            //tbxFiyatUpdate.Text = dgw_Sigaralar.CurrentRow.Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgw_Sigaralar.SelectedRows)
            {

                object[] rowData = new object[row.Cells.Count];

                for (int i = 0; i <= 3; ++i)
                {
                    rowData[i] = row.Cells[i].Value;

                }


                this.dgw_Hesaplar.Rows.Add(rowData);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgw_Çerezler.SelectedRows)
            {

                object[] rowData = new object[row.Cells.Count];

                for (int i = 0; i <= 3; ++i)
                {
                    rowData[i] = row.Cells[i].Value;

                }


                this.dgwhesaplarcerezler.Rows.Add(rowData);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgw_Gıdalar.SelectedRows)
            {

                object[] rowData = new object[row.Cells.Count];

                for (int i = 0; i <= 3; ++i)
                {
                    rowData[i] = row.Cells[i].Value;

                }


                this.dgwhesaplargıda.Rows.Add(rowData);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplamAdet = 0;

            listBox1.Items.Clear();
            for (int i = 0; i < dgw_Hesaplar.Rows.Count; ++i)
            {
                double Fiyat = 0;
                int adet = 0;
                double sonuc = 0;

                adet += Convert.ToInt32(dgw_Hesaplar.Rows[i].Cells[3].Value);
                Fiyat += Convert.ToDouble(dgw_Hesaplar.Rows[i].Cells[2].Value);
                toplamAdet += Convert.ToInt32(dgw_Hesaplar.Rows[i].Cells[3].Value);
                for (int k = 0; k < 1; k++)
                {
                    sonuc = adet * Fiyat;
                    k++;
                }
                listBox1.Items.Add(sonuc.ToString());
            }

            double toplam = 0;
            for (int l = 0; l < listBox1.Items.Count; l++)
            {
                toplam += Convert.ToDouble(listBox1.Items[l]);
            }
            label1.Text = toplam.ToString();
            label3.Text = toplamAdet.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int toplamAdet = 0;
            for (int i = 0; i < dgwhesaplarcerezler.Rows.Count; ++i)
            {
                double Fiyat = 0;
                int adet = 0;
                double sonuc = 0;

                adet += Convert.ToInt32(dgwhesaplarcerezler.Rows[i].Cells[3].Value);
                Fiyat += Convert.ToDouble(dgwhesaplarcerezler.Rows[i].Cells[2].Value);
                toplamAdet += Convert.ToInt32(dgwhesaplarcerezler.Rows[i].Cells[3].Value);
                for (int k = 0; k < 1; k++)
                {
                    sonuc = adet * Fiyat;
                    k++;
                }
                listBox2.Items.Add(sonuc.ToString());

            }
            double toplam = 0;
            for (int l = 0; l < listBox2.Items.Count; l++)
            {
                toplam += Convert.ToDouble(listBox2.Items[l]);
            }
            label7.Text = toplam.ToString();
            label8.Text = toplamAdet.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int toplamAdet = 0;
            listBox3.Items.Clear();
            for (int i = 0; i < dgwhesaplargıda.Rows.Count; ++i)
            {
                double Fiyat = 0;
                int adet = 0;
                double sonuc = 0;

                adet += Convert.ToInt32(dgwhesaplargıda.Rows[i].Cells[3].Value);
                Fiyat += Convert.ToDouble(dgwhesaplargıda.Rows[i].Cells[2].Value);
                toplamAdet += Convert.ToInt32(dgwhesaplarcerezler.Rows[i].Cells[3].Value);

                for (int k = 0; k < 1; k++)
                {
                    sonuc = adet * Fiyat;
                    k++;
                }
                listBox3.Items.Add(sonuc.ToString());
            }
            double toplam = 0;
            for (int l = 0; l < listBox3.Items.Count; l++)
            {
                toplam += Convert.ToDouble(listBox3.Items[l]);
            }
            label11.Text = toplam.ToString();
            label12.Text = toplamAdet.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label14.Text = "...";
            double sayi1 = Convert.ToDouble(label1.Text);
            double sayi2 = Convert.ToDouble(label7.Text);
            double sayi3 = Convert.ToDouble(label11.Text);
            label14.Text = Convert.ToString(sayi1 + sayi2 + sayi3);

       
        }
    }
}
