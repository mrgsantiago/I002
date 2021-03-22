using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I002
{
    public partial class ChangeProduct : Form
    {
        string IdProduct = null;
        public ChangeProduct(string Id,string NameProduct)
        {
            InitializeComponent();
            IdProduct = Id;
            TxtAddProduct.Text = NameProduct;
        }

        private void BtnChangeProduct_Click(object sender, EventArgs e)
        {
            if (TxtAddProduct.Text.Trim() !=String.Empty)
            {
                EntityProduct product = new EntityProduct();
                product.ChangeProduct(TxtAddProduct.Text, Convert.ToInt32(IdProduct));
                MessageBox.Show("Успешно измененно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите название!");
            }

        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Products products = new Products();
            products.Show();
        }
    }
}
