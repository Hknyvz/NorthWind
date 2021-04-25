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
        IEnumerable<Employess> employees;
        bool isUpdate = false;
        int id = 0;
        int index = -1;
        public EmployeesPage()
        {
            InitializeComponent();
            apiServices = new ApiServices("employee");
        }

        private async void EmployeesPage_Load(object sender, EventArgs e)
        {
            tbxTerriyoryIds.Text = "123,213,45,12";
            tbxTerriyoryIds.ForeColor = Color.Gray;
            await FillDataGridView();
            
        }

        private async Task FillDataGridView()
        {
            await FillArray();
            Type type = typeof(Employess);
            foreach (var item in type.GetProperties())
            {
                dgvEmployees.Columns.Add(item.Name, item.Name);
            }
            foreach (var item in employees)
            {
                string fullAdress = "";
                
                if (item.Address!=null)
                {
                    fullAdress = $"{item.Address.Street} {item.Address.City} {item.Address.Country} {item.Address.Region} {item.Address.PostalCode}";
                }
                dgvEmployees.Rows.Add(item.Id, item.FirstName, item.LastName, item.Title, item.TitleOfCourtesy, item.BirthDate, item.HireDate, fullAdress, item.Notes, item.ReportsTo, GetTerritoryIds(item.TerritoryIds)) ;
            }
        }
        private async Task FillArray()
        {
            employees = await apiServices.GetEntitiesAsync<Employess>();
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
        
        private void dgvEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            Employess employee = employees.SingleOrDefault(p => p.Id == id);
            tbxCity.Text = employee.Address.City;
            tbxCountry.Text = employee.Address.Country;
            tbxFirstName.Text = employee.FirstName;
            tbxLastName.Text = employee.LastName;
            tbxPostalCode.Text = employee.Address.PostalCode;
            tbxRegion.Text = employee.Address.Region;
            tbxReportsTo.Text = employee.ReportsTo;
            tbxStreet.Text = employee.Address.Street;
            tbxTerriyoryIds.Text = GetTerritoryIds(employee.TerritoryIds);
            tbxTitle.Text = employee.Title;
            tbxTitleOfCourtesy.Text = employee.Title;
            rtbNotes.Text = employee.Notes;
            dtpBirthDate.Value = Convert.ToDateTime(employee.BirthDate);
            dtpHireDate.Value = Convert.ToDateTime(employee.HireDate);
            isUpdate = true;
            index = dgvEmployees.CurrentRow.Index;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var territoryIds = tbxTerriyoryIds.Text.Split(",");
            ICollection<int> territoryIdCollection = new HashSet<int>();
            foreach (var item in territoryIds)
            {
                int.TryParse(item, out int territoryId);
                territoryIdCollection.Add(territoryId);
            }
            Employess employee = new Employess
            {
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                Notes = rtbNotes.Text,
                ReportsTo = tbxReportsTo.Text,
                TerritoryIds = territoryIdCollection,
                BirthDate = dtpBirthDate.Value.ToString(),
                HireDate = dtpHireDate.Value.ToString(),
                Title=tbxTitle.Text,
                TitleOfCourtesy=tbxTitleOfCourtesy.Text,
                Address = new Address
                {
                    City = tbxCity.Text,
                    Country = tbxCountry.Text,
                    PostalCode = tbxPostalCode.Text,
                    Region = tbxRegion.Text,
                    Street = tbxStreet.Text

                }
            };

            if (isUpdate)
            {
                employee.Id = id;
                await apiServices.UpdateEntityAsync(employee);
                isUpdate = false;
            }
            else
            {
                await apiServices.AddEntityAsync(employee);
            }
            await FillDataGridView();
            Clear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                await apiServices.DeleteEntityAsync<Employess>(id.ToString());
                dgvEmployees.Rows.RemoveAt(index);
                index = -1;
                isUpdate = false;
                Clear();
            }
        }

        private void tbxTerriyoryIds_Enter(object sender, EventArgs e)
        {
            tbxTerriyoryIds.Clear();
            tbxTerriyoryIds.ForeColor = Color.Black;

        }

        private void Clear()
        {
            tbxCity.Clear();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxReportsTo.Clear();
            tbxTerriyoryIds.Clear();
            tbxTitle.Clear();
            tbxTitleOfCourtesy.Clear();
            dtpBirthDate.Value = DateTime.Now;
            dtpHireDate.Value = DateTime.Now;
            rtbNotes.Clear();
            tbxCountry.Clear();
            tbxPostalCode.Clear();
            tbxRegion.Clear();
            tbxStreet.Clear();
        }
    }
}
