using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public static class CustomerDB
	{
		// TODO: Add the directory and path here
		private const string dir = @"C:\C#\Files\";
		private const string path = dir + "Customer.txt";


        public static void SaveCustomers(List<Customer> customers)
		{
			// TODO: Add code that writes the List<> of Customer objects 
			// to a text file 
			using StreamWriter textOut =
				new StreamWriter(
				new FileStream(
					path, FileMode.Create, FileAccess.Write));

			foreach (Customer customer in customers)
			{
				textOut.Write(customer.FirstName + "|");
				textOut.Write(customer.LastName + "|");
				textOut.Write(customer.Email);
			}

			textOut.Close();

        }

        public static List<Customer> GetCustomers()
		{
            List<Customer> customers = new List<Customer>();

            // TODO: Add code that reads a List<> of Customer objects 
            // from a text file
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using StreamReader textIn =
                new StreamReader(
                new FileStream(
                    path, FileMode.OpenOrCreate, FileAccess.Read));

            while (textIn.Peek() != -1)
			{
				string row = textIn.ReadLine();
				string[] columns = row.Split('|');
				Customer customer = new Customer();
				customer.FirstName = columns[0];
				customer.LastName = columns[1];
				customer.Email = columns[2];
				customers.Add(customer);
			}
			textIn.Close();

			return customers;
		}
	}
}
