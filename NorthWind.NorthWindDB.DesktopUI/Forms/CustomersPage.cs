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
    public partial class CustomersPage : Form
    {
        ApiServices apiServices;
        IEnumerable<Customers> customers;
        bool isUpdate = false;
        string id = "";
        int index = -1;
        public CustomersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("customer");
        }

        private async void CustomersPage_Load(object sender, EventArgs e)
        {
            await FillDataGridView();
        }
        private async Task FillDataGridView()
        {
            dgvCustomers.Columns.Clear();
            await FillArray();
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
        }

        

        private void Clear()
        {
            tbxCity.Clear();
            tbxCompanyName.Clear();
            tbxContactName.Clear();
            tbxContactTitle.Clear();
            tbxCountry.Clear();
            tbxPhone.Clear();
            tbxPostalCode.Clear();
            tbxRegion.Clear();
            tbxStreet.Clear();
        }

       

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            Customers customer = customers.SingleOrDefault(p => p.Id == id);
            tbxCompanyName.Text = customer.CompanyName;
            tbxContactName.Text = customer.ContactName;
            tbxCity.Text = customer.Address.City;
            tbxContactTitle.Text = customer.ContactTitle;
            tbxCountry.Text = customer.Address.Country;
            tbxPhone.Text = customer.Address.Phone;
            tbxRegion.Text = customer.Address.Region;
            tbxStreet.Text = customer.Address.Street;
            tbxPostalCode.Text = customer.Address.PostalCode;
            isUpdate = true;
            index = dgvCustomers.CurrentRow.Index;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (index != -1)
            {
                await apiServices.DeleteEntityAsync<Customers>(id.ToString());
                dgvCustomers.Rows.RemoveAt(index);
                index = -1;
                isUpdate = false;
                Clear();
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers
            {
                ContactTitle = tbxContactTitle.Text,
                CompanyName = tbxCompanyName.Text,
                ContactName = tbxContactName.Text,
                Address = new Address
                {
                    City = tbxCity.Text,
                    Country = tbxCountry.Text,
                    Phone = tbxPhone.Text,
                    PostalCode = tbxPostalCode.Text,
                    Region = tbxRegion.Text,
                    Street = tbxStreet.Text
                }
            };

            if (isUpdate)
            {
                customer.Id = id;
                await apiServices.UpdateEntityAsync(customer);
                isUpdate = false;
            }
            else
            {
                await apiServices.AddEntityAsync(customer);
            }
            await FillDataGridView();
            Clear();
        }
    }
}

