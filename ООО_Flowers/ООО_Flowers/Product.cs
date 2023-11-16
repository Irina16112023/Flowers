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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnAuthriz_Click(object sender, EventArgs e)
        {
            Authoriz authoriz = new Authoriz();
            authoriz.Show();
            Hide();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flawersDataSet1._Product_". При необходимости она может быть перемещена или удалена.
            this.product_TableAdapter.Fill(this.flawersDataSet1._Product_);

        }
    }
}
