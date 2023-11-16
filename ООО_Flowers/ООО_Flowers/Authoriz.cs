using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ООО_Flowers
{
    public partial class Authoriz : Form

    {
        DataBase dataBase = new DataBase();
        
        public Authoriz()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Product product = new Product();
            product.Show();
            Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAuthoris_Click(object sender, EventArgs e)
        {
            var LoginUser = txtLogin.Text;
            var PasswordUser = txtPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select UserLogin, UserPassword, UserRole from [User] where UserLogin= '{LoginUser}' and UserPassword='{PasswordUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успещно вошли!", "Успешно! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EditProduct editProduct = new EditProduct();
                editProduct.Show();
                Hide();


            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
