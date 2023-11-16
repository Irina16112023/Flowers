using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООО_Flowers
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authoriz authoriz = new Authoriz();
            authoriz.Show();
            Hide();

        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flawersDataSet._Product_". При необходимости она может быть перемещена или удалена.
            this.product_TableAdapter.Fill(this.flawersDataSet._Product_);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.productBindingSource.EndEdit();
            this.product_TableAdapter.Update(this.flawersDataSet._Product_);
        }
    }
}
