using System;

namespace UserDefineException
{
    public class CostomExceptio:ApplicationException
    {
        public CostomExceptio() : base()
        {

        }
        public CostomExceptio(string message) : base(message)
        {

        }
    }
    public class employee
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if(value >= 20 && value<=59)
                {
                    age = value;
                }
                else
                {
                    CostomExceptio CO = new CostomExceptio("Age must be between 20 to 60");
                    throw CO;
                }
            }
        }
        class CostExcp
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                try
                {
                    emp.Age = 60;
                    Console.WriteLine("Age=" + emp.Age);
                }
                catch(CostomExceptio CE)
                {
                    
                }

            }
        }
    }
    
}
