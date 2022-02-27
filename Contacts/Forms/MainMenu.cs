using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Contacts.Forms
{
    public partial class MainMenu : Form
    {
        private readonly IPersonBusiness _personBusiness;
        public MainMenu(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ShowDialog("New", null);
        }

        private void ShowDialog(string command, Person person) 
        {
            new AddEditPerson(command, _personBusiness, person).ShowDialog();
            RefreshData();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            populateDataGridView(_personBusiness.GetAllContacts());
        }

        private void populateDataGridView(List<Person> contacts)
        {
            dataGridView.Rows.Clear();

            foreach (Person p in contacts)
            {
                dataGridView.Rows.Add(new object[]
                {
                    p.Id,
                    p.FirstName,
                    p.LastName,
                    p.Address,
                    p.Phone,
                    p.Email,
                    "Edit",
                    "Delete"
                });
            }
            ;

            dataGridView.ClearSelection();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Person person = new Person()
                {
                    Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value),
                    FirstName = Convert.ToString(dataGridView.SelectedRows[0].Cells["firstName"].Value),
                    LastName = Convert.ToString(dataGridView.SelectedRows[0].Cells["lastName"].Value),
                    Phone = Convert.ToString(dataGridView.SelectedRows[0].Cells["phone"].Value),
                    Address = Convert.ToString(dataGridView.SelectedRows[0].Cells["address"].Value),
                    Email = Convert.ToString(dataGridView.SelectedRows[0].Cells["email"].Value)
                };

                ShowDialog("Update", person);
            }
            else if (e.ColumnIndex == 7)
            {
                _personBusiness.DeleteContact(Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value));
                RefreshData();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text.Trim()))
            {
                applySearch();
            }
            else
            {
                RefreshData();
            }
        }

        private void applySearch()
        {
            List<Person> contacts = _personBusiness.GetAllContacts();

            dataGridView.Rows.Clear();
            foreach (Person p in contacts)
            {
                if (p.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                {
                    dataGridView.Rows.Add(new object[]
                    {
                    p.Id,
                    p.FirstName,
                    p.LastName,
                    p.Address,
                    p.Phone,
                    p.Email,
                    "Edit",
                    "Delete"
                    });

                    dataGridView.ClearSelection();
                }
            }
        }

        private void textBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(textBoxSearch, "Start typing contact's full name");
        }
    }
}
