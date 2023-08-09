namespace Assignment2_Ka_Hang_Chan
{
    public partial class Form1 : Form
    {
        List<Customer> customerlist = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }
        private void add()
        {
            foreach (Customer customer in customerlist)
            {
                lstCustomers.Items.Add("Name: " + customer.firstName + " " + customer.lastName + "  Email: " + customer.email);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addCustomerForm form2 = new addCustomerForm();
            form2.ShowDialog();
            if (form2.btnSave.DialogResult == DialogResult.OK)
            {
                if (!customerlist.Contains(new Customer(form2.firstName, form2.lastName, form2.email)))
                    customerlist.Add(new Customer(form2.firstName, form2.lastName, form2.email));
                lstCustomers.Items.Clear();
                this.add();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i >= 0)
            {
                lstCustomers.Items.RemoveAt(i);
                customerlist.RemoveAt(i);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}