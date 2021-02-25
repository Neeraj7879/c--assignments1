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
                Console.WriteLine("Type Y if you want to update data or any other key to exit ");
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
        private static void Getdata(Employee employee)
        {
            Console.WriteLine($"Employee Id     :- {employee.GetId()}");
            Console.WriteLine();
            Console.WriteLine($"Employee Name   :- {employee.GetName()}");
            Console.WriteLine();
            Console.WriteLine($"Department Name :- {employee.GetDepartmentName()}");


        }
        /* Data Update Method*/
        private static void Updatedata(Employee employee)
        {
            Console.WriteLine("Select option to update \n 1.Only update ID \n 2.Only update Name \n 3.Only Update departnment \n 4.Update all");
            int case_no = Convert.ToInt32(Console.ReadLine());
            switch (case_no)
            {
                case 1:
                    Console.WriteLine("Write id to be updated");
                    int id = Convert.ToInt32(Console.ReadLine());
                    employee.update(id);
                    break;

                case 2:
                    Console.WriteLine("Write name to be updated");
                    string name = Console.ReadLine();
                    employee.update(name);
                    break;

                case 3:
                    Console.WriteLine("Write id to be updated");
                    int id_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write department_name to be updated");
                    string DepartmentName = Console.ReadLine();
                    employee.update(id_2, DepartmentName);
                    break;

                case 4:
                    Console.WriteLine("Write id to be updated");
                    int id_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write name to be updated");
                    string name_1 = Console.ReadLine();
                    Console.WriteLine("Write department_name to be updated");
                    string DepartmentName_1 = Console.ReadLine();
                    employee.updateALL(id_1, name_1, DepartmentName_1);
                    break;



            }
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
