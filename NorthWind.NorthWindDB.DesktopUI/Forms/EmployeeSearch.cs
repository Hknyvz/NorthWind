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
    public partial class EmployeeSearch : Form
    {
        public Employess Employee { get; set; }
        ApiServices apiServices;
        IEnumerable<Employess> employees;
        int id = 0;
        public EmployeeSearch()
        {
            InitializeComponent();
            apiServices = new ApiServices("employee");
        }

        private async void EmployeeSearch_Load(object sender, EventArgs e)
        {
            await FillArray();
        }

        private void FillDataGridView(IEnumerable<Employess> employees)
        {
            Type type = typeof(Employess);
            foreach (var item in type.GetProperties())
            {
                dgvEmployees.Columns.Add(item.Name, item.Name);
            }
            foreach (var item in employees)
            {
                string fullAdress = "";

                if (item.Address != null)
                {
                    fullAdress = $"{item.Address.Street} {item.Address.City} {item.Address.Country} {item.Address.Region} {item.Address.PostalCode}";
                }
                dgvEmployees.Rows.Add(item.Id, item.FirstName, item.LastName, item.Title, item.TitleOfCourtesy, item.BirthDate, item.HireDate, fullAdress, item.Notes, item.ReportsTo, GetTerritoryIds(item.TerritoryIds));
            }
        }
        private async Task FillArray()
        {
            employees = await apiServices.GetEntitiesAsync<Employess>();
            FillDataGridView(employees);
        }

        private string GetTerritoryIds(ICollection<int> territoryIds)
        {
            string territoryIdsText = "";
            foreach (var territoryId in territoryIds)
            {
                territoryIdsText += territoryId + ",";
            }
            return territoryIdsText.Remove(territoryIdsText.Length - 1);

        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            Employee = employees.SingleOrDefault(p => p.Id == id);
            tbxEmployeeName.Text = $"{Employee.FirstName} {Employee.LastName}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var entities = employees.Where(p => p.FirstName.ToLower().Contains(tbxSearch.Text.ToLower())||p.LastName.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();
            FillDataGridView(entities);
        }
    }
}
