using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    class AddressBookDataTable
    {
        //Creating DataTable for addressbook problem UC1
        DataTable dataTable = new DataTable();

        /// Create the Address Book table and add attributes.

        public void createAddressBookTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Rows.Add("Vishal", "Singh", "Bhandup", "Mumbai", "Maharashtra", 400078, 9930315160, "vishal@gmail.com");
            dataTable.Rows.Add("Himanshu", "Kholiya", "Wakad", "Pune", "Maharashtra", 600701, 9987932434, "himanshu@gmail.com");
            dataTable.Rows.Add("Omprakash", "Khawshi", "Pratap Nagar", "Pune", "Maharashtra", 600703, 9987932434, "Omprakash@gmail.com");
            dataTable.Rows.Add("Priyesh", "Sharma", "dombivli", "Mumbai", "Maharashtra", 400710, 9987932434, "priyesh@gmail.com");
            dataTable.Rows.Add("Chandan", "Yadav", "chembor", "Mumbai", "Maharashtra", 400703, 9987932434, "Chandan@gmail.com");
            dataTable.Rows.Add("Laukik", "bhoir", " koper khairne", "Navimumbai", "Maharashtra", 400701, 9987932434, "bhoir@gmail.com");
            dataTable.Rows.Add("Ashok", "Parde", "vashi", "Navimumbai", "Maharashtra", 400701, 9987932434, "parde@gmail.com");
            displayAddressBook();
        }

        public void displayAddressBook()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("\nFirstName:-" + row.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + row.Field<string>("LastName"));
                Console.WriteLine("Address:-" + row.Field<string>("Address"));
                Console.WriteLine("City:-" + row.Field<string>("City"));
                Console.WriteLine("State:-" + row.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + row.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + row.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + row.Field<string>("Email"));
            }
        }
    }

}