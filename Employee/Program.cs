using System;
/* Main file / Main Class*/
namespace c__assignmet1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try and catch for getting only interger id */
            try
            {

                Console.WriteLine();
                Console.Write("Enter Employee Name   :- ");
                String Name = Console.ReadLine();

                Console.Write("Enter Employee Id     :- ");
                int id_temp = Convert.ToInt32(Console.ReadLine());
                int id = 0;

                /* if else for only getting positive id values*/
                if (id_temp >= 1)
                {
                    id = id_temp;
                }
                else
                {
                    Console.WriteLine("Enter a positive Integer as ID");

                }
                Console.Write("Enter Department Name :- ");
                String DepartmentName = Console.ReadLine();

                var employee = new Employee(id, Name, DepartmentName);
                employee.NameCall += Event_NameCalled;
                employee.IdCall += Event_IdCalled;
                employee.DepNameCall += Event_DeptNameCalled;
                Getdata(employee);

                /* update Data Part*/

                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("Type Y if you want to update data or any other to exit ");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                if (Convert.ToChar(Console.ReadLine()) == 'y')
                {
                    Updatedata(employee);
                }
                else
                {
                    Console.WriteLine("");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid integer ID");
            }



        }
        /* Data Print Method*/
        private static void Getdata()
        {
            Console.WriteLine($"Employee Id     :- {employee.GetId()}");
            Console.WriteLine();
            Console.WriteLine($"Employee Name   :- {employee.GetName()}");
            Console.WriteLine();
            Console.WriteLine($"Department Name :- {employee.GetDepartmentName()}");


        }
        /* Data Update Method*/
        private static void Updatedata()
        {
            Console.WriteLine("Write id to be updated");
            int id = Convert.ToInt32(Console.ReadLine());
            employee.update(id);
            Console.WriteLine("Write name to be updated");
            string name = Console.ReadLine();
            employee.update(name);
            Console.WriteLine("Write department_name to be updated");
            string DepartmentName = Console.ReadLine();
            employee.update(id, DepartmentName);
            Console.WriteLine("");
            Console.WriteLine("Data Successfully updated");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Updated Result : ");
            Getdata(employee);

        }

        /* event calls */
        static void Event_IdCalled(object sender, EventArgs e)
        {
            Console.WriteLine(" ");
            Console.WriteLine("GetId() Called ");

        }
        static void Event_NameCalled(object sender, EventArgs e)
        {
            Console.WriteLine("GetName() Called ");
        }
        static void Event_DeptNameCalled(object sender, EventArgs e)
        {
            Console.WriteLine("GetDepartmentName() Called");
        }

    }
}
