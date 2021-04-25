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
    public partial class RequestLogsPage : Form
    {
        ApiServices apiServices;
        public RequestLogsPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("requestlog");
        }

        private async void RequestLogsPage_Load(object sender, EventArgs e)
        {
            dgvRequestLogs.DataSource = await apiServices.GetEntitiesAsync<RequestLog>();
        }
    }
}
