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
        public SuppliersPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("supplier");
        }

        private async void SuppliersPage_Load(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource =await apiServices.GetEntitiesAsync<Suppliers>();
        }
    }
}
