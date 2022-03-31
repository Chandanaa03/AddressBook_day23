using System;

namespace AddressBook
{
    /// <summary>
    /// contains main method
    /// </summary>
    class program
    {
        /// <summary>
        /// Displaying Greeting message
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            //CreateContacts obj = new CreateContacts();
            //obj.addperson();
            editname obj = new editname();
            obj.Editname();
        }
    }
}

