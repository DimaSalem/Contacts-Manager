using Contacts_Manager;


namespace ContactManagerTests
{
    public class UnitTest1
    {
 
        [Theory]
        [InlineData("Dima", new [] {"DIMA"})]

        //test if the app will add a new contact as DIMA (duplicate one) or not. 
        [InlineData("dima", new[] { "DIMA" })]

        //test if the app will add an empty contact or not.
        [InlineData("", new[] { "DIMA" })]
        
        [InlineData("Maha", new[] { "DIMA", "MAHA" })]
        public void AddContactAllCases(string contact, string [] contacts)
        {
            List <string> actualData = Program.AddContact(contact);
            List <string> expectedData = new List<string>(contacts);

            Assert.Equal(contacts, actualData);
        }

        [Theory]

        [InlineData("Dima", new string[] { })]
        public void RemoveContactCase(string contact, string[] contacts)
        {
            Program.RemoveAllContacts();
            Program.AddContact(contact);

            List<string> actualData = Program.RemoveContact(contact);
            List<string> expectedData = new List<string>(contacts);

            Assert.Equal(contacts, actualData);
        }

        [Fact]
        public void ViewAllContactsCase()
        {
            Program.AddContact("Dima");
            Program.AddContact("Maha");
            Program.AddContact("Abdullah");

            List<string> actualData = Program.ViewAllContacts();
            List<string> expectedData = new List<string> { "DIMA", "MAHA", "ABDULLAH" };

            Assert.Equal(expectedData, actualData);
        }

    }
}