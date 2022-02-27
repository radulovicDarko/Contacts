using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Contacts.Forms
{
    public partial class AddEditPerson : Form
    {
        private string _command = "";
        private Person _person;
        private readonly IPersonBusiness _personBusiness;
        private Regex _regexPhone;
        private Regex _regexEmail;

        public AddEditPerson(string command, IPersonBusiness personBusiness, Person person)
        {
            InitializeComponent();

            _regexPhone = new Regex(@"^([0-9]{10})$|^([()]{1})$");
            _regexEmail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                    + "@"
                                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            _person = person;
            _personBusiness = personBusiness;
            _command = command;
        }

        private void AddEditPerson_Load(object sender, EventArgs e)
        {
            labelTitle.Text = _command + " Contact";

            switch (_command)
            {
                case "New": buttonNew.Visible = true; this.Text = "New Contact"; break;
                case "Update": buttonSave.Visible = true; this.Text = "Update Contact"; initializeFields(); break;
                default: break;
            }
        }

        private void initializeFields()
        {
            textBoxFirstName.Text = _person.FirstName.Trim();
            textBoxLastName.Text = _person.LastName.Trim();
            textBoxPhone.Text = _person.Phone.Trim();
            textBoxAddress.Text = _person.Address.Trim();
            textBoxEmail.Text = _person.Email.Trim();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Person person = new Person();

                person.FirstName = textBoxFirstName.Text;
                person.LastName = textBoxLastName.Text;
                person.Phone = textBoxPhone.Text;
                person.Address = textBoxAddress.Text;
                person.Email = textBoxEmail.Text;

                if (_personBusiness.InsertContact(person))
                {
                    this.Close();
                }
                else
                {
                    ShowError("Data not inserted! Try again later!");
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Person person = new Person();

                person.Id = _person.Id;
                person.FirstName = textBoxFirstName.Text;
                person.LastName = textBoxLastName.Text;
                person.Phone = textBoxPhone.Text;
                person.Address = textBoxAddress.Text;
                person.Email = textBoxEmail.Text;

                if (_personBusiness.UpdateContact(person))
                {
                    this.Close();
                }
                else
                {
                    ShowError("Data not updated! Try again later!");
                }
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        private void textBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                e.Cancel = true;
                textBoxFirstName.Focus();
                errorProvider.SetError(textBoxFirstName, "Please enter your first name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxFirstName, null);
            }
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                e.Cancel = true;
                textBoxFirstName.Focus();
                errorProvider.SetError(textBoxLastName, "Please enter your last name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxLastName, null);
            }
        }

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                    e.Cancel = true;
                    textBoxPhone.Focus();
                    errorProvider.SetError(textBoxPhone, "Please enter your phone number!");
            }
            else if (!_regexPhone.IsMatch(textBoxPhone.Text))
            {
                e.Cancel = true;
                textBoxPhone.Focus();
                errorProvider.SetError(textBoxPhone, "Please enter your phone number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPhone, null);
            }
        }

        private void textBoxAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                e.Cancel = true;
                textBoxFirstName.Focus();
                errorProvider.SetError(textBoxAddress, "Please enter your address!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxAddress, null);
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                e.Cancel = true;
                textBoxFirstName.Focus();
                errorProvider.SetError(textBoxEmail, "Please enter your email!");
            }
            else if (!_regexEmail.IsMatch(textBoxEmail.Text))
            {
                e.Cancel = true;
                textBoxEmail.Focus();
                errorProvider.SetError(textBoxEmail, "Please enter your address!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxEmail, null);
            }
        }
    }
}
