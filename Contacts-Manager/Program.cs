namespace Contacts_Manager
{
    public class Program
    {
        
        static private List<string> contacts= new List<string>();
        enum enUserOptions { addContact = 1, removeContact = 2, viewAllContacts = 3 }

        static void Main(string[] args)
        {
           
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine(contacts[i]);
            }
        }

        static public List<string> AddContact(string contactName)
        {
            Console.WriteLine("Please Enter the contact name");
            string input= Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("the contact name can not be empty, please try again");
                input = Console.ReadLine();
            }
            while (contacts.Contains(input.ToLower()))
            {
                Console.WriteLine($"{input} is already exist,please enter a new contact");
                input = Console.ReadLine();
            }
            contacts.Add(input.ToLower());
            return contacts;
        }
        static public List<string> RemoveContact() 
        {



            return null;
        }

        static public void MainScreen()
        {
            Console.WriteLine("--------------- Contact Manager ---------------");
            Console.WriteLine("[1]Add New Contact");
            Console.WriteLine("[2]Remove Contact");
            Console.WriteLine("[3]View All Contacts");
            Console.Write("Please choose an option: ");
        }
        static public void ContactsManager()
        {
            MainScreen();
            int input = Console.ReadLine().Trim();
            while (string.IsNullOrEmpty(input) || (input != 1 && input != 2 && input != 3))
            {
                Console.WriteLine("please chose an option");
                input = Console.ReadLine();
            }

            switch ((enUserOptions)input) 
            { }

        }




    }
    }
}
