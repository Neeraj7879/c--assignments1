using System;

namespace c__assignmet1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine();
                Console.Write("Enter Name :- ");
                String Name = Console.ReadLine();

                Console.Write("Enter Id :- ");
                int id_temp = Convert.ToInt32(Console.ReadLine());
                int id = 0;
                if (id_temp >= 1)
                {
                    id = id_temp;
                }
                else
                {
                    Console.WriteLine("Enter a positive no.");

                }
                Console.Write("Enter Department Name :-");
                String DepartmentName = Console.ReadLine();

                var employee = new Employee(id, Name, DepartmentName);
                employee.NameCall += Event_NameCalled;
                employee.IdCall += Event_IdCalled;
                employee.DepNameCall += Event_DeptNameCalled;


                Console.WriteLine($"Id :- {employee.GetId()}");
                Console.WriteLine($"Name :- {employee.GetName()}");
                Console.WriteLine($"Department Name :- {employee.GetDepartmentName()}");
            }

            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid integer ID");
            }



        }
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
