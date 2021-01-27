using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Application_Medium2
{
    class EmployeePromotion
    {
        static void Main(string[] args)
        {

            //1. 
            Dictionary<int, string> employees = new Dictionary<int, string>();     //employees dictionary
            int num = 1;
            while (num == 1)
            {
                Employee emp = new Employee();
                emp.TakeEmployeeDetailsFromUser();                                  //taking all the employee details
                int key = emp.Id;
                string value = emp.Name + " " + emp.Age + " " + emp.Salary;
                employees.Add(key, value.ToString());
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                num = Convert.ToInt32(Console.ReadLine());
            }

            foreach (KeyValuePair<int, string> items in employees)
                Console.WriteLine(items.Key + " " + items.Value);

            Console.ReadKey();

            Console.WriteLine("Please enter the employee ID");                      //Printing details of particular Empoyee Id
            int EmpId = Convert.ToInt32(Console.ReadLine());
            foreach (var obj in employees.Keys)
            {
                int key = Convert.ToInt32(obj.ToString());
                if (key == EmpId)
                {
                    Console.WriteLine("Id Name Age Salary");
                    Console.WriteLine("===================");
                    Console.WriteLine(key + ":" + employees[obj]);
                    Console.WriteLine("===================");
                }
            }





            //2.a
            //List<Employee> employeelist = new List<Employee>();                     //Empty Employee list
            //int num = 1;
            //Employee emp = new Employee();
            //while (num == 1)
            //{

            //    emp.TakeEmployeeDetailsFromUser();
            //    employeelist.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
            //    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
            //    num = Convert.ToInt32(Console.ReadLine());

            //}


            //foreach (var i in employeelist)                                         //Printing employee details list
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After Sorting based on salary");

            //var sorted_list = emp.SortAndPrintEmployees(employeelist);              //Sorting employee details in increasing order of salries
            //sorted_list.ForEach(x => Console.WriteLine(x + " "));

            //2.b
            //Console.WriteLine("Please enter the employee ID");
            //int EmpId = Convert.ToInt32(Console.ReadLine());

            //List<Employee> query = emp.PrintEmployee(EmpId, sorted_list);           //Printing employee details of user entered Employee Id
            //foreach (var empdata in query)
            //{
            //    Console.WriteLine(empdata);
            //}



            //3.
            //List<Employee> employeelist = new List<Employee>();
            //int num = 1;
            //Employee emp = new Employee();
            //while (num == 1)
            //{

            //    emp.TakeEmployeeDetailsFromUser();
            //    employeelist.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
            //    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
            //    num = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("The sorted employee list");                          //Printing Sorted Employee List
            //var sortedlist = emp.SortEmployeeDetailsById(employeelist);
            //foreach (var empdata in sortedlist)
            //{
            //    Console.WriteLine(empdata);
            //}

            //Console.WriteLine("Please enter the employee Name");                   //Printinf Employee details of user entered employee name
            //string EmpName = Console.ReadLine();

            //List<Employee> query = emp.GetDetailsByName(EmpName, sortedlist);
            //foreach (var empdata in query)
            //{
            //    Console.WriteLine(empdata);
            //}



            //4.
            //List<Employee> employeelist = new List<Employee>();
            //int num = 1;
            //Employee emp = new Employee();
            //while (num == 1)
            //{

            //    emp.TakeEmployeeDetailsFromUser();
            //    employeelist.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
            //    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
            //    num = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("Please enter the employee ID");
            //int EmpId = Convert.ToInt32(Console.ReadLine());

            //List<Employee> Elder_empdata = emp.GetElderEmployee_data(EmpId, employeelist);         //Getting all the elder employees of user entered employee id


            //foreach (var empdata in Elder_empdata)
            //{
            //    Console.WriteLine(empdata);
            //}


        }




    }
}
