using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class HomePage : Form
    {
        string selectedItem;
        public HomePage()
        {
            InitializeComponent();
            selectedItem = "HomePage";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listBoxItem = listBox1.SelectedItem.ToString();
            Console.WriteLine(listBoxItem);
            if (listBoxItem == "Products")
            {
                selectedItem = "Product";
            }
            else if (listBoxItem == "Categories")
            {
                selectedItem = "Category";
            }
            else if (listBoxItem == "Users")
            {
                selectedItem = "User";
            }
            else if (listBoxItem == "Orders")
            {
                selectedItem = "Order";
            }
            else if (listBoxItem == "Customers")
            {
                selectedItem = "Customer";
            }
            //[TODO]: add more else if statements here for additional forms created

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            switch(selectedItem)
            {

               case "Product":
                    Product product = new Product();
                    product.Show();
                    this.Hide();
                    break;
                case "Category":
                    Category category = new Category();
                    category.Show();
                    this.Hide();
                    break;
                case "User":
                    User user = new User();
                    user.Show();
                    this.Hide();
                    break;
                case "Order":
                    Orders orders = new Orders();
                    orders.Show();
                    this.Hide();
                    break;
                case "Customer":
                    Customer customer = new Customer();
                    customer.Show();
                    this.Hide();
                    break;
                default:
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    break;
                //[TODO]: add more cases here for additional forms created
            }
        }
    }
}
