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
    public partial class ProductsPage : Form
    {
        ApiServices apiServices;
        public ProductsPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("product");
        }

        private async void ProductsPage_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = await apiServices.GetEntitiesAsync<Products>();
        }
    }
}
