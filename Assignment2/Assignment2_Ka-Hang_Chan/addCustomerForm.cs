using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Assignment2_Ka_Hang_Chan
{
    public partial class addCustomerForm : Form
    {
        public addCustomerForm()
        {
            InitializeComponent();
        }

        public string firstName;
        public string lastName;
        public string email;

        public void Valid()
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            Regex regex2 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "")
            {
                throw new InvalidInputException(
                    "Input field(s) should have a value, Error");
            }

            if (!regex.IsMatch(txtFirstName.Text))
            {
                throw new InvalidFirstNameException(
                    "First name cannot contains special character(s) and number(s). Error.");
            }

            if (!regex.IsMatch(txtLastName.Text))
            {
                throw new InvalidLastNameException(
                    "Last name cannot contains special character(s) and number(s). Error.");
            }

            if (!regex2.IsMatch(txtEmail.Text))
            {
                throw new InvalidEmailException(
                    "Please input a valid email address (e.g. abc@gmail.com). Error");
            }

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            email = txtEmail.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Valid();
                btnSave.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(InvalidInputException ie)
            {
                MessageBox.Show(ie.Message);
            }
            catch(InvalidFirstNameException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch(InvalidLastNameException le)
            {
                MessageBox.Show(le.Message);
            }
            catch(InvalidEmailException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
    public class InvalidInputException : Exception
    {
        public InvalidInputException(String message)
            : base(message)
        {

        }
    }

    public class InvalidFirstNameException : Exception
    {
        public InvalidFirstNameException(String message)
            : base(message)
        {

        }
    }
    public class InvalidLastNameException : Exception
    {
        public InvalidLastNameException(String message)
            : base(message)
        {

        }
    }
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(String message)
            : base(message)
        {

        }
    }
}
