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
    public partial class SuppliersPage : Form
    {
        ApiServices apiServices;
        IEnumerable<Suppliers> suppliers;
        bool isUpdate = false;
        int id = 0;
        int index = -1;
        public SuppliersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("supplier");
        }

        private async void SuppliersPage_Load(object sender, EventArgs e)
        {
            await FillDataGridView();
        }
        private async Task FillDataGridView()
        {
            await FillArray();
            Type type = typeof(Suppliers);
           
            foreach (var item in type.GetProperties())
            {
                dgvSuppliers.Columns.Add(item.Name, item.Name);
            }
            dgvSuppliers.Columns.Add("phone", "phone");
            foreach (var item in suppliers)
            {
                string fullAddress = "";
                if (true)
                {
                    fullAddress = $"{item.Address.Street} {item.Address.City} {item.Address.Country} {item.Address.Region} {item.Address.PostalCode}";
                }
                dgvSuppliers.Rows.Add(item.Id, item.CompanyName, item.ContactName, item.ContactTitle, fullAddress, item.Address.Phone);
            }
        }
        private async Task FillArray()
        {
            suppliers = await apiServices.GetEntitiesAsync<Suppliers>();
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value);
            Suppliers supplier = suppliers.SingleOrDefault(p => p.Id == id);
            tbxCompanyName.Text = supplier.CompanyName;
            tbxContactName.Text = supplier.ContactName;
            tbxCity.Text = supplier.Address.City;
            tbxContactTitle.Text = supplier.ContactTitle;
            tbxCountry.Text = supplier.Address.Country;
            tbxPhone.Text = supplier.Address.Phone;
            tbxRegion.Text = supplier.Address.Region;
            tbxStreet.Text = supplier.Address.Street;
            tbxPostalCode.Text = supplier.Address.PostalCode;
            isUpdate = true;
            index = dgvSuppliers.CurrentRow.Index;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers
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
                supplier.Id = id;
                await apiServices.UpdateEntityAsync(supplier);
                isUpdate = false;
            }
            else
            {
                await apiServices.AddEntityAsync(supplier);
            }
            await FillDataGridView();
            Clear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                await apiServices.DeleteEntityAsync<Suppliers>(id.ToString());
                dgvSuppliers.Rows.RemoveAt(index);
                index = -1;
                isUpdate = false;
                Clear();
            }

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
    }
}
