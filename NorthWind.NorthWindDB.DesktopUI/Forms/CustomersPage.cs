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
        public CustomersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("customer");
        }

        private async void CustomersPage_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = await apiServices.GetEntitiesAsync<Customers>();
        }
    }
}
