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
        public OrdersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("order");
        }

        private async void OrdersPage_Load(object sender, EventArgs e)
        {
            dgvOrders.DataSource = await apiServices.GetEntitiesAsync<Orders>();
        }
    }
}
