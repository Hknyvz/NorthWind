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
        public CategoriesPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("category");
        }
        ApiServices apiServices;

        private async void CategoriesPage_Load(object sender, EventArgs e)
        {
            dgvCategories.DataSource =await apiServices.GetEntitiesAsync<Categories>();
        }
    }
}
