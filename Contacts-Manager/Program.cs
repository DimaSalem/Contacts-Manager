namespace Contacts_Manager
{
    public class Program
    {
        
        static private List<string> contacts= new List<string>();
        enum enUserOptions { addContact = 1, removeContact = 2, viewAllContacts = 3 }
        static public List<string> AddContact(string contact)
        {
            if (!string.IsNullOrEmpty(contact) && !contacts.Contains(contact.ToUpper()))
                contacts.Add(contact.ToUpper());
            return contacts;
        }
        static public List<string> RemoveContact(string contact) 
        {
            if (contacts.Contains(contact.ToUpper()))
                contacts.Remove(contact.ToUpper());
            return contacts;
        }
        static public List<string> ViewAllContacts()
        {
            return contacts;
        }
        static public void RemoveAllContacts() 
        {
            contacts.Clear();
        }

        static private string readContact()
        {
            Console.WriteLine("Enter the contact name");
            string input = Console.ReadLine();
            return input;
        }
        static private void showMainScreen()
        {
            Console.WriteLine("--------------- Contact Manager ---------------");
            Console.WriteLine("[1]Add New Contact");
            Console.WriteLine("[2]Remove Contact");
            Console.WriteLine("[3]View All Contacts");
            Console.Write("Please choose an option: ");
        }
        static private enUserOptions readOption()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input) || !input.All(char.IsDigit) || (input != "1" && input != "2" && input != "3"))
            {
                Console.WriteLine("Invalid input!, try again");
                input = Console.ReadLine();
            }
            bool success = Int16.TryParse(input, out Int16 option);
            return (enUserOptions)option;
        }
        static private void performOption(enUserOptions option)
        {
            Console.Clear();
            switch (option)
            {
                case enUserOptions.addContact:
                    AddContact(readContact());
                    break;
                case enUserOptions.removeContact:
                    RemoveContact(readContact());
                    break;
                case enUserOptions.viewAllContacts:
                    ViewAllContacts();
                    break;
            }
            Console.WriteLine("Press any key to go back to Main Menue...");
            Console.ReadKey();
            ContactsManager();
        }
        static public void ContactsManager()
        {
            Console.Clear();
            showMainScreen();
            try
            {
                performOption(readOption());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             
        }
        static void Main(string[] args)
        {
            ContactsManager();
        }
    }

}

