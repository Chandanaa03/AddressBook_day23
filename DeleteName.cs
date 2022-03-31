using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class DeleteName
    {
        public List<DeleteName> People = new List<DeleteName>();
        public void deletecontact()
        {
            DeleteName person = new DeleteName();
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string FirstName = Console.ReadLine();

            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            else
            {

                People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();

            }
        }
    }
}
