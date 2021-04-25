using NorthWind.NorthWindDB.Entites.LogEntities;
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
    public partial class ResponseLogsPage : Form
    {
        ApiServices apiServices;
        public ResponseLogsPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("responselog");
        }

        private async void ResponseLogsPage_Load(object sender, EventArgs e)
        {
            dgvResponseLogs.DataSource = await apiServices.GetEntitiesAsync<ResponseLog>();
        }
    }
}
