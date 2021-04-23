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
    public partial class EmployeesPage : Form
    {
        ApiServices apiServices;
        public EmployeesPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("employee");
        }

        private async void EmployeesPage_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = await apiServices.GetEntitiesAsync<Employess>();
        }
    }
}
