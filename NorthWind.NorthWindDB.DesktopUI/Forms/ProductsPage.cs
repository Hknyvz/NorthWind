using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.NorthWindDB.DesktopUI.Forms
{
    public partial class ProductsPage : Form
    {
        ApiServices apiServices;
        ApiServices apiServicesCategory;
        ApiServices apiServicesSupplier;
        IEnumerable<Products> products;
        IEnumerable<Categories> categories;
        IEnumerable<Suppliers> suppliers;
        bool isUpdate = false;
        int id = 0;
        int index = -1;
        public ProductsPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("product");
            apiServicesCategory = new ApiServices("category");
            apiServicesSupplier = new ApiServices("supplier");
        }

        private async void ProductsPage_Load(object sender, EventArgs e)
        {
            categories = await apiServicesCategory.GetEntitiesAsync<Categories>();
            cbxCategory.DataSource = categories;
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";
            cbxCategory.SelectedItem = null;
            cbxCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCategory.AutoCompleteSource = AutoCompleteSource.ListItems;

            suppliers = await apiServicesSupplier.GetEntitiesAsync<Suppliers>();
            cbxSupplier.DataSource = suppliers;
            cbxSupplier.DisplayMember = "CompanyName";
            cbxSupplier.ValueMember = "Id";
            cbxSupplier.SelectedItem = null;
            cbxSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;

            dgvProduct.Columns.Add("Id", "Id");
            dgvProduct.Columns.Add("Name", "Name");
            dgvProduct.Columns.Add("SupplierName", "Supplier Name");
            dgvProduct.Columns.Add("CategoryName", "Category Name");
            dgvProduct.Columns.Add("QuantityPerUnit", "Quantity Per Unit");
            dgvProduct.Columns.Add("UnitPrice", "Unit Price");
            dgvProduct.Columns.Add("UnitsInStock", "Units In Stock");
            dgvProduct.Columns.Add("UnitsOnOrder", "Units On Order");
            dgvProduct.Columns.Add("ReorderLevel", "Reorder Level");
            dgvProduct.Columns.Add("Discontinued", "Discontinued");
            await FillDataGridView();

        }



        private async Task FillDataGridView()
        {
            await FillArray();
            Type type = typeof(Products);
            
            foreach (var item in products)
            {
                string categoryName = item.Category != null ? item.Category.Name : "";
                string supplierName = item.Supplier != null ? item.Supplier.CompanyName : "";
                dgvProduct.Rows.Add(
                    item.Id,
                    item.Name,
                    supplierName,
                    categoryName,
                    item.QuantityPerUnit,
                    item.UnitPrice,
                    item.UnitsInStock,
                    item.UnitsOnOrder,
                    item.ReorderLevel,
                    item.Discontinued);
            }
        }
        private async Task FillArray()
        {
            products = await apiServices.GetEntitiesAsync<Products>();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);
            Products product = products.SingleOrDefault(p => p.Id == id);
            tbxDiscontinued.Text = product.Discontinued;
            tbxName.Text = product.Name;
            tbxQuantityPerUnit.Text = product.QuantityPerUnit;
            tbxReorderLevel.Text = product.ReorderLevel.ToString();
            tbxUnitPrice.Text = product.UnitPrice.ToString();
            tbxUnitsInStock.Text = product.UnitsInStock.ToString();
            tbxUnitsOnOrder.Text = product.UnitsOnOrder.ToString();
            if (product.Category != null)
            {
                cbxCategory.SelectedValue = product.Category.Id;
            }
            if (product.Supplier != null)
            {
                cbxSupplier.SelectedValue = product.Supplier.Id;
            }
            isUpdate = true;
            index = dgvProduct.CurrentRow.Index;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                await apiServices.DeleteEntityAsync<Products>(id.ToString());
                dgvProduct.Rows.RemoveAt(index);
                index = -1;
                isUpdate = false;
                Clear();
            }
        }

        private void Clear()
        {
            tbxDiscontinued.Clear();
            tbxName.Clear();
            tbxQuantityPerUnit.Clear();
            tbxReorderLevel.Clear();
            tbxUnitPrice.Clear();
            tbxUnitsInStock.Clear();
            tbxUnitsOnOrder.Clear();
            cbxCategory.SelectedItem = null;
            cbxSupplier.SelectedItem = null;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Products product = new Products
                {
                    Name = tbxName.Text,
                    Discontinued = tbxDiscontinued.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    ReorderLevel = Convert.ToInt16(tbxReorderLevel.Text),
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitsInStock.Text),
                    UnitsOnOrder = Convert.ToInt16(tbxUnitsOnOrder.Text),
                };
                if (cbxCategory.SelectedItem != null)
                {
                    product.CategoryID = Convert.ToInt32(cbxCategory.SelectedValue);
                    product.Category = categories.FirstOrDefault(p => p.Id == product.CategoryID);
                }
                if (cbxSupplier.SelectedItem != null)
                {
                    product.SupplierID = Convert.ToInt32(cbxSupplier.SelectedValue);
                    product.Supplier = suppliers.FirstOrDefault(p => p.Id == product.SupplierID);
                }

                if (isUpdate)
                {
                    product.Id = id;
                    await apiServices.UpdateEntityAsync(product);
                    isUpdate = false;
                }
                else
                {
                    await apiServices.AddEntityAsync(product);
                }
                await FillDataGridView();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            Clear();
        }
    }
}
