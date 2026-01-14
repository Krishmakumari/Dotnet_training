// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace LINQ_ConsoleApp
{
    class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8, 27 };
            string[] nameArray = {"Alok","Rajat","Sumeet","Priya","Ayush","Krishma","Harshita","Himanshu","Teja","Sai" };

            //doing with simple approach
            //foreach (var item in numArray)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Linq Query
            //string datatoSearch = " ";
            Console.WriteLine("Enter Name to Search: ");
            string name = Console.ReadLine();

            var result = from data in nameArray
                         //where data == name
                         orderby data
                         select data;
            
            //another way
            //var result = nameArray.Where(n => n == name);

            foreach (var item in result)
            {
                Console.WriteLine(item); 
            }
        }

        public static void LinqToObjectDemoCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer{CustomerId=101, Name="ALok",City="Pune"},
                new Customer{CustomerId=102, Name="Aliya",City="Mumbai"},
                new Customer{CustomerId=103, Name="Dheeraj",City="Delhi"},
                new Customer{CustomerId=104, Name="Danish",City="Pune"},
                new Customer{CustomerId=105, Name="Smita",City="Delhi"},
                new Customer{CustomerId=106, Name="Naveen",City="Pune"},
                new Customer{CustomerId=107, Name="Prachi",City="Delhi"},
                new Customer{CustomerId=108, Name="Megha",City="Mumbai"},

            };

            //anonymous object
            var data = new { OrderID = 1110, OrdrDate = "12/01/2025", TotalAmount = 14000 };

            var result = custList.Where(cust => cust.City == "Mumbai");

            //.find gives the first occurrence 
            var result1 = custList.Find(cust => cust.City == "Delhi");


            foreach (var item in result)
            { 
                Console.WriteLine($"{item.CustomerId} \t {item.Name} \t {item.City}");
            }

        }

        //ToLookUp -> group items by a key and store the groups for quick reuse.
        public static void LambdaLookUpStudentList()
        {
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();

            var query = tempList.ToLookup(s => s.Gender == "Male");
            foreach (IGrouping<bool,Student> group in query)
            {
                //Console.WriteLine("Key : {0}", group.Key);
                int totFees = 0;
                if(group.Key==true)
                {
                    Console.WriteLine("Male Student details below: ");
                }
                else
                {
                    Console.WriteLine("Female Student details below: ");
                }
                foreach (Student std in group)
                {
                    Console.WriteLine($"{std.Name}");
                    totFees += std.Fees;
                }
                Console.WriteLine("Total fees paid: "+totFees);
            }
            //var maleFeesPaid = tempList.ToLookup(s => s.Gender == "Male").Sum();
        }

        public static void Main(string[] args)
        {
            //LinqToObjectDemo();
            //LinqToObjectDemoCustomType();
            //LambdaLookUpStudentList();

            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList= sRepo.GetAllStudents();
            var total = tempList.Select(s => s.Fees).Max(); //Min, Sum, Max
            Console.WriteLine(total);
        }
        
        
    }
}