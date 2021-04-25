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
    public partial class SearchProducts : Form
    {
        public Products Product { get; set; }

        public OrderDetails OrderDetail { get; set; }
        ApiServices apiServices;
        IEnumerable<Products> products;
        int id = 0;

        public SearchProducts()
        {
            InitializeComponent();
            apiServices = new ApiServices("product");
            OrderDetail = new OrderDetails();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            OrderDetail.Discount = Convert.ToDouble(tbxDiscount.Text);
            OrderDetail.ProductId = Product.Id;
            OrderDetail.Quantity = Convert.ToInt32(tbxQuantity.Text);
            OrderDetail.UnitPrice = Product.UnitPrice.Value;
        }

        private async void SerachProducts_Load(object sender, EventArgs e)
        {
            dgvProducts.Columns.Add("Id", "Id");
            dgvProducts.Columns.Add("Name", "Name");
            dgvProducts.Columns.Add("SupplierName", "Supplier Name");
            dgvProducts.Columns.Add("CategoryName", "Category Name");
            dgvProducts.Columns.Add("QuantityPerUnit", "Quantity Per Unit");
            dgvProducts.Columns.Add("UnitPrice", "Unit Price");
            dgvProducts.Columns.Add("UnitsInStock", "Units In Stock");
            dgvProducts.Columns.Add("UnitsOnOrder", "Units On Order");
            dgvProducts.Columns.Add("ReorderLevel", "Reorder Level");
            dgvProducts.Columns.Add("Discontinued", "Discontinued");
            await FillArray();

        }
        private void FillDataGridView(IEnumerable<Products> products)
        {
            dgvProducts.Rows.Clear();
            foreach (var item in products)
            {
                string categoryName = item.Category != null ? item.Category.Name : "";
                string supplierName = item.Supplier != null ? item.Supplier.CompanyName : "";
                dgvProducts.Rows.Add(
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
            FillDataGridView(products);
        }
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            Products product = products.SingleOrDefault(p => p.Id == id);
            tbxName.Text = product.Name;
            Product = product;
        }

        private void tbxSerach_TextChanged(object sender, EventArgs e)
        {
            var entities = products.Where(p => p.Name.ToLower().Contains(tbxSerach.Text.ToLower())).ToList();
            FillDataGridView(entities);
        }
    }
}
