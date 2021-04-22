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
        public OrdersPage()
        {
            InitializeComponent();
        }

        private async void OrdersPage_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("ClientType", "Desktop");
            httpClient.BaseAddress = new Uri("http://localhost:61643/");
            HttpResponseMessage response = await httpClient.GetAsync("api/order");
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<ICollection<Orders>>(await response.Content.ReadAsStringAsync());
                dgvOrders.DataSource = data;
            }
        }
    }
}
