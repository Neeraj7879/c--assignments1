using System;

namespace c__assignmet1
{
    public delegate void IdCalledDelegate(object sender, EventArgs args);

    /* Employee class for computation */
    public class Employee
    {
        /* private declation of variable*/
        private int id;
        private string name;
        private string departmentName;

        public Employee(int id, string name, string departmentName)
        {
            /* Constructor call*/
            this.id = id;
            this.name = name;
            this.departmentName = departmentName;
        }

        public event IdCalledDelegate IdCall;
        public event IdCalledDelegate NameCall;

        public event IdCalledDelegate DepNameCall;

        public int GetId()
        {
            /* event call*/
            IdCall(this, new EventArgs());
            return id;
        }

        public String GetName()
        {
            /* event call*/
            NameCall(this, new EventArgs());
            return name;
        }

        public String GetDepartmentName()
        {
            /* event call*/
            DepNameCall(this, new EventArgs());
            return departmentName;
        }

        public void Set(int id)
        {
            this.id = id;
        }
        public void Set(String Name)
        {
            this.name = Name;
        }
        public void Set(int id, String Name, String DepartmentName)
        {
            this.departmentName = DepartmentName;
        }

        public void update(int id_update)
        {
            this.id = id_update;
        }
        public void update(string name_update)
        {
            this.name = name_update;
        }

        public void update(int id_update, string departmentName_update)
        {
            if (this.id == id_update)
                this.departmentName = departmentName_update;
        }


    }
}