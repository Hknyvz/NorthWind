using Newtonsoft.Json;
using NorthWind.NorthWindDB.Entites.NorthWindEntities;
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

namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    public partial class CategoriesPage : Form
    {
        ApiServices apiServices;
        IEnumerable<Categories> categories;
        bool isUpdate = false;
        int id = 0;
        int index = -1;
        public CategoriesPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("category");
        }

        private async void CategoriesPage_Load(object sender, EventArgs e)
        {
            await FillDataGridView();
        }
        private async Task FillDataGridView()
        {
            dgvCategories.Columns.Clear();
            await FillArray();
            Type type = typeof(Categories);
            foreach (var item in type.GetProperties())
            {
                dgvCategories.Columns.Add(item.Name, item.Name);
            }
            foreach (var item in categories)
            {
                dgvCategories.Rows.Add(item.Id, item.Name, item.Description);

            }
        }

        private async Task FillArray()
        {
            categories = await apiServices.GetEntitiesAsync<Categories>();
        }

       
        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCategories.CurrentRow.Cells[0].Value);
            Categories category = categories.SingleOrDefault(p => p.Id == id);
            tbxCategoryName.Text = category.Name;
            tbxDescription.Text = category.Description;
            isUpdate = true;
            index = dgvCategories.CurrentRow.Index;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            Categories category = new Categories
            {
                Description = tbxDescription.Text,
                Name = tbxCategoryName.Text
            };
            if (isUpdate)
            {
                category.Id = id;
                await apiServices.UpdateEntityAsync(category);
            }
            else
            {
                await apiServices.AddEntityAsync(category);
            }
            await FillDataGridView();
            Clear();
        }

        private void Clear()
        {
            tbxCategoryName.Clear();
            tbxDescription.Clear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (index!=-1)
            {
                await apiServices.DeleteEntityAsync<Categories>(id.ToString());
                dgvCategories.Rows.RemoveAt(index);
                index = -1;
                isUpdate = false;
                Clear();
            }
        }

       
    }
}
