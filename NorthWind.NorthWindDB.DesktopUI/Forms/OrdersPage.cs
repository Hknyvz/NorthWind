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
    public partial class OrdersPage : Form
    {
        ApiServices apiServices;
        ApiServices apiServicesShipper;
        ApiServices apiServicesCustomer;
        ApiServices apiServicesEmployee;
        ApiServices apiServicesProduct;
        IEnumerable<Orders> orders;
        bool isUpdate = false;
        int id = 0;
        int index = -1;
        public Customers Customer { get; set; }
        public Employess Employee { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public OrdersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("order");
            apiServicesShipper = new ApiServices("shipper");
            apiServicesCustomer = new ApiServices("customer");
            apiServicesEmployee = new ApiServices("employee");
            apiServicesProduct = new ApiServices("product");
            OrderDetails = new List<OrderDetails>();
            CheckForIllegalCrossThreadCalls = false;
        }

        private async void OrdersPage_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnAddProduct.Enabled = false;
            btnCustomerSerach.Enabled = false;
            btnEmployeeSearch.Enabled = false;
            await FillDataGridView();
            btnAddProduct.Enabled = true;
            btnCustomerSerach.Enabled = true;
            btnEmployeeSearch.Enabled = true;
            cbxShipper.DataSource = await apiServicesShipper.GetEntitiesAsync<Shippers>();
            cbxShipper.DisplayMember = "CompanyName";
            cbxShipper.ValueMember = "Id";
            cbxShipper.SelectedItem = null;
            Cursor = Cursors.Default;
        }

        private async Task FillDataGridView()
        {
            await FillArray();
            dgvOrders.Rows.Clear();
            Type type = typeof(Orders);
            foreach (var item in type.GetProperties())
            {
                dgvOrders.Columns.Add(item.Name, item.Name);
            }
            dgvOrders.Columns.Remove("Details");
            foreach (var item in orders)
            {
                string fullAdress = "";
                if (item.ShipAddress != null)
                {
                    fullAdress = $"{item.ShipAddress.Street} {item.ShipAddress.City} {item.ShipAddress.Country} {item.ShipAddress.Region} {item.ShipAddress.PostalCode}";
                }
                dgvOrders.Rows.Add(
                    item.Id,
                    item.CustomerId,
                    item.EmployeeId,
                    item.OrderDate,
                    item.RequiredDate,
                    item.ShippedDate,
                    item.ShipVia,
                    item.Freight,
                    item.ShipName,
                    fullAdress);
            }
        }

        private async Task FillArray()
        {
            orders = await apiServices.GetEntitiesAsync<Orders>();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProducts searchCustomer = new SearchProducts();
            if (searchCustomer.ShowDialog() == DialogResult.OK)
            {
                lbProducts.Items.Add(searchCustomer.Product.Name);
                OrderDetails.Add(searchCustomer.OrderDetail);
            }
        }

        private void btnCustomerSerach_Click(object sender, EventArgs e)
        {
            CustomerSearch customerSearch = new CustomerSearch();

            if (customerSearch.ShowDialog() == DialogResult.OK)
            {
                Customer = customerSearch.Customer;
                tbxCustomer.Text = Customer.CompanyName;
            }
        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            EmployeeSearch employeeSearch = new EmployeeSearch();
            if (employeeSearch.ShowDialog()==DialogResult.OK)
            {
                Employee = employeeSearch.Employee;
                tbxEmployee.Text = $"{Employee.FirstName} {Employee.LastName}";
            }
        }

        private async void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbProducts.Items.Clear();
            id = Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value);
            Orders order = orders.SingleOrDefault(p => p.Id == id);
            var employee = await apiServicesEmployee.GetEntityAsync<Employess>(order.EmployeeId);
            tbxCity.Text = order.ShipAddress.City;
            tbxCountry.Text = order.ShipAddress.Country;
            tbxPostalCode.Text = order.ShipAddress.PostalCode;
            tbxRegion.Text = order.ShipAddress.Region;
            tbxStreet.Text = order.ShipAddress.Street;
            await apiServicesCustomer.GetEntityAsync<Customers>(order.CustomerId).ContinueWith((res)=> tbxCustomer.Text=res.Result.CompanyName);
            await apiServicesEmployee.GetEntityAsync<Employess>(order.EmployeeId).ContinueWith((res) => tbxEmployee.Text = $"{res.Result.FirstName} {res.Result.LastName}");
            
            dtpOerderDate.Value = Convert.ToDateTime(order.OrderDate);
            dtpRequireDate.Value = Convert.ToDateTime(order.RequiredDate);
            tbxShipName.Text = order.ShipName;
            tbxFreight.Text = order.Freight.ToString();
            foreach (var item in order.Details)
            {
                await apiServicesProduct.GetEntityAsync<Products>(item.ProductId).ContinueWith((res)=>lbProducts.Items.Add(res.Result.Name));
            }
            cbxShipper.SelectedValue = order.ShipVia;
            dtpShippedDate.Value = Convert.ToDateTime(order.ShippedDate);
            index = dgvOrders.CurrentRow.Index;
            isUpdate = true;
        }

        

        private async void btnSend_Click(object sender, EventArgs e)
        {

            Orders order = new Orders
            {
                CustomerId = Customer.Id,
                EmployeeId = Employee.Id,
                Freight = Convert.ToDecimal(tbxFreight.Text),
                OrderDate = dtpOerderDate.Text,
                RequiredDate = dtpRequireDate.Text,
                ShipAddress = new BaseAddress
                {
                    City = tbxCity.Text,
                    Street = tbxStreet.Text,
                    Country = tbxCountry.Text,
                    PostalCode = tbxPostalCode.Text,
                    Region = tbxRegion.Text
                },
                ShipName = tbxShipName.Text,
                ShipVia = Convert.ToInt32(cbxShipper.SelectedValue),
                Details = OrderDetails,
                ShippedDate=dtpShippedDate.Text
            };
           
            if (isUpdate)
            {
                order.Id = id;
                await apiServices.UpdateEntityAsync(order);
                isUpdate = false;
            }
            else
            {
                await apiServices.AddEntityAsync(order);
            }
            await FillDataGridView();
            Clear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                await apiServices.DeleteEntityAsync<Orders>(id.ToString());
                dgvOrders.Rows.RemoveAt(index);
                index = -1;
                isUpdate = false;
                Clear();
            }
        }

        private void Clear()
        {
            tbxCity.Clear();
            tbxCountry.Clear();
            tbxCustomer.Clear();
            tbxEmployee.Clear();
            tbxFreight.Clear();
            tbxPostalCode.Clear();
            tbxRegion.Clear();
            tbxShipName.Clear();
            tbxStreet.Clear();
            dtpOerderDate.Value = DateTime.Now;
            dtpRequireDate.Value = DateTime.Now;
            dtpShippedDate.Value = DateTime.Now;
            lbProducts.Items.Clear();
            cbxShipper.SelectedItem = null;
        }
    }
}
