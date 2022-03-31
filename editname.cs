using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class editname
    {
        public string Name { get; set; }
       
        public List<editname> People = new List<editname>();

        public void Editname()
        {
            editname person = new editname();
           
            if (Editname == null)
            {
                Console.WriteLine("Address for {0} count not be found.", person);
            }
            else
            {
                Console.Write("Enter Name to Edit: ", person);
                person.Name = Console.ReadLine();
                
            }
            
        }
    }
}
