using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Application_Medium2
{
    public class Employee
    {
        int id, age;
        string name;
        double salary;

        public Employee()
        {
        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
        }


        

        //2.a
        public List<Employee> SortAndPrintEmployees(List<Employee> Emplist)
        {
            return Emplist.OrderBy(x => x.Salary).ToList();
        }

        //2.b
        public List<Employee> PrintEmployee(int EmpId, List<Employee> sortedEmplist)
        {
            return sortedEmplist.Where(e => e.Id == EmpId).ToList();
        }

        //3.
        public List<Employee> GetDetailsByName(string EmpName,List<Employee> sorted_Emplist)
        {
            return sorted_Emplist.Where(n => n.Name == EmpName).ToList();
        }

        public List<Employee> SortEmployeeDetailsById(List<Employee> sorted_Emplist)
        {
            return sorted_Emplist.OrderBy(x=>x.Id).ToList();
        }


        //4.
        public List<Employee> GetElderEmployee_data(int EmpId,List<Employee> sorted_emplist)
        {

            int Empage = (from emp in sorted_emplist where emp.Id == EmpId select emp.Age).FirstOrDefault();
            
            return sorted_emplist.Where(e => e.Age > Empage).ToList();
            
            
        }





        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }


    




}
