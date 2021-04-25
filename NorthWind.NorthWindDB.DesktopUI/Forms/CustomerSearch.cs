using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    public partial class CustomerSearch : Form
    {
        public Customers Customer { get; set; }
        ApiServices apiServices;
        IEnumerable<Customers> customers;
        string id = "";
        public CustomerSearch()
        {
            InitializeComponent();
            apiServices = new ApiServices("customer");
        }

        private async void CustomerSearch_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private void FillDataGridView(IEnumerable<Customers> customers)
        {
            dgvCustomers.Columns.Clear();
           
            Type type = typeof(Customers);
            foreach (var item in type.GetProperties())
            {
                dgvCustomers.Columns.Add(item.Name, item.Name);
            }
            dgvCustomers.Columns.Add("phone", "Phone");
            foreach (var item in customers)
            {
                dgvCustomers.Rows.Add(item.Id, item.CompanyName, item.ContactName, item.ContactTitle, $"{item.Address.Street} {item.Address.City} {item.Address.Country} {item.Address.Region} {item.Address.PostalCode}", item.Address.Phone);
            }
        }

        private async Task FillArray()
        {

            customers = await apiServices.GetEntitiesAsync<Customers>();
            FillDataGridView(customers);
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            Customer = customers.SingleOrDefault(p => p.Id == id);
            tbxCustomerName.Text = Customer.CompanyName;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var entities = customers.Where(p => p.CompanyName.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();
            FillDataGridView(entities);
        }
    }
}
