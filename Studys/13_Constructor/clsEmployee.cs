using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsEmployee
    {
        //props

        public int Id, Age;
        public string Address, Name;
        public bool isActive;

        public clsEmployee() { //User-defined Constructor

            Id = 100;      //this.Id ' de kullanılabilir.
            Age = 30;
            Address = "Istanbul";
            Name = "Ertu";
            isActive = true;
        } 
        
        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee Id: {Id}\n Employee Age: {Age}\n Employee Name: {Name} \n Employee Adress: {Address}\n Employee Active?: {isActive}");
        }


    }
}
