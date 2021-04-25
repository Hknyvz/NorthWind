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
    public partial class ShippersPage : Form
    {
        ApiServices apiServices;
        IEnumerable<Shippers> shippers;
        bool isUpdate = false;
        int id = 0;
        int index = -1;
        public ShippersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("shipper");
        }

        private async void ShippersPage_Load(object sender, EventArgs e)
        {
           await FillDataGridView();
        }

        private async Task FillDataGridView()
        {
            dgvShippers.Columns.Clear();
            await FillArray();
            Type type = typeof(Categories);
            foreach (var item in type.GetProperties())
            {
                dgvShippers.Columns.Add(item.Name, item.Name);
            }
            foreach (var item in shippers)
            {
                dgvShippers.Rows.Add(item.Id, item.CompanyName, item.Phone);

            }
        }

        private async Task FillArray()
        {
            shippers = await apiServices.GetEntitiesAsync<Shippers>();
        }
        

        private void dgvShippers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvShippers.CurrentRow.Cells[0].Value);
            Shippers shipper = shippers.SingleOrDefault(p => p.Id == id);
            tbxCompanyName.Text = shipper.CompanyName;
            tbxPhone.Text = shipper.Phone;
            isUpdate = true;
            index = dgvShippers.CurrentRow.Index;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            Shippers shipper = new Shippers
            {
                CompanyName = tbxCompanyName.Text,
                Phone = tbxPhone.Text
            };
            if (isUpdate)
            {
                shipper.Id = id;
                await apiServices.UpdateEntityAsync(shipper);
            }
            else
            {
                await apiServices.AddEntityAsync(shipper);
            }
            await FillDataGridView();
            Clear();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                await apiServices.DeleteEntityAsync<Shippers>(id.ToString());
                dgvShippers.Rows.RemoveAt(index);
                index = -1;
                isUpdate = false;
                Clear();
            }
        }

        private void Clear()
        {
            tbxCompanyName.Clear();
            tbxPhone.Clear();
        }

    }
}
