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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if(TxtAddProduct.Text.Trim()!=string.Empty)
            {
                EntityProduct product = new EntityProduct();
                product.AddProduct(TxtAddProduct.Text);
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
