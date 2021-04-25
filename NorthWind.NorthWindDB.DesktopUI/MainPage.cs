using NorthWind.NorthWindDB.DesktopUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.NorthWindDB.DesktopUI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            //HttpClient httpClient = new HttpClient();
            //httpClient.DefaultRequestHeaders.Add("ClientType", "Desktop");
            //httpClient.BaseAddress = new Uri("http://localhost:61643/");
            //HttpResponseMessage response = await httpClient.GetAsync("api/category");
        }

        


        private void orders_Click(object sender, EventArgs e)
        {
            OrdersPage ordersPage = new OrdersPage();
            ordersPage.ShowDialog();
        }
        private void categories_Click(object sender, EventArgs e)
        {
            CategoriesPage categoriesPage = new CategoriesPage();
            categoriesPage.ShowDialog();
        }

        private void products_Click(object sender, EventArgs e)
        {
            ProductsPage productsPage = new ProductsPage();
            productsPage.ShowDialog();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            CustomersPage customersPage = new CustomersPage();
            customersPage.ShowDialog();
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            SuppliersPage suppliersPage = new SuppliersPage();
            suppliersPage.ShowDialog();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            EmployeesPage employeesPage = new EmployeesPage();
            employeesPage.ShowDialog();
        }

        private void shippers_Click(object sender, EventArgs e)
        {
            ShippersPage shippersPage = new ShippersPage();
            shippersPage.ShowDialog();
        }

        private void logs_Click(object sender, EventArgs e)
        {
            RequestLogsPage requestLogsPage = new RequestLogsPage();
            requestLogsPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResponseLogsPage responseLogsPage = new ResponseLogsPage();
            responseLogsPage.ShowDialog();
        }
    }
}
