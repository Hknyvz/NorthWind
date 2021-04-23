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
        public ShippersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("shipper");
        }

        private async void ShippersPage_Load(object sender, EventArgs e)
        {
            dgvShippers.DataSource = await apiServices.GetEntitiesAsync<Shippers>();
        }
    }
}
