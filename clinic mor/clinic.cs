using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_mor
{
    class Clinic
    {
        int possin;
        string idkey =string.Empty; 

        Patient p = new Patient();
        employee e = new employee();
        public void pat_serv()
        {
            Console.WriteLine("Choose one of the following features:");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Remove Patient");
            Console.WriteLine("3. Edit Patient Information");
            Console.WriteLine("4. Print Specific Patient Information");
            Console.WriteLine("5. Print All Patient Names");
            Console.WriteLine("6. Search for a Patient ");

            Console.Write("Enter your choice: ");
            int chose = Convert.ToInt32(Console.ReadLine());

            switch (chose)
            {
                case 1: p.AddPerson(); break;
                case 2:
                    Console.WriteLine(" enter id  ");
                    if (!string.IsNullOrEmpty(idkey))
                    {
                        idkey = Console.ReadLine();
                        possin = p.SearchIndex(idkey);
                        p.RemovePerson(possin);
                    }
                    else Console.WriteLine(" error ");
                    break;
                case 3: p.Edit();

                    break;
                case 4:
                    Console.WriteLine(" enter id  ");
                    idkey = Console.ReadLine();

                    if (!string.IsNullOrEmpty(idkey))
                    {
                        possin = p.SearchIndex(idkey);
                        p.PrintInfo(possin);
                    }
                    else Console.WriteLine(" you have n't entered yor id ");
                    break;
                case 5: p.PrintList(); break;
                case 6:
                    Console.WriteLine(" enter id  ");
                    if (!string.IsNullOrEmpty(idkey))
                    {
                        idkey = Console.ReadLine();
                        possin = p.SearchIndex(idkey);
                        p.PrintInfo(possin);
                    }
                    else Console.WriteLine(" you have n't entered yor id ");
                    break;

                default: Console.WriteLine("wrong input "); break;
            }

        }

        public void emp_serv()
        { 
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Edit Employee Information");
            Console.WriteLine("4. Print Specific Employee Information");
            Console.WriteLine("5. Print All Employee Names");
            Console.WriteLine("6. Search for an Employee by Name");

            Console.Write("Enter your choice: ");
            int chose = Convert.ToInt32(Console.ReadLine());

            int empIndex;
            string empIdKey;



            switch (chose)
            {
                case 1:
                    e.AddPerson();
                    break;
                case 2:
                    Console.WriteLine("Enter ID: ");
                    empIdKey = Console.ReadLine();
                    empIndex = e.SearchIndex(empIdKey);
                    e.RemovePerson(empIndex);
                    break;
                case 3:
                    e.Edit();
                    break;
                case 4:
                    Console.WriteLine("Enter ID: ");
                    empIdKey = Console.ReadLine();
                    empIndex = e.SearchIndex(empIdKey);
                    e.PrintInfo(empIndex);
                    break;
                case 5:
                    Console.WriteLine("Enter ID: ");
                    empIdKey = Console.ReadLine();
                    empIndex = e.SearchIndex(empIdKey);
                    e.PrintInfo(empIndex);
                    break;
                case 6:
                    Console.WriteLine("Enter ID: ");
                    empIdKey = Console.ReadLine();
                    empIndex = e.SearchIndex(empIdKey);
                    e.PrintInfo(empIndex);
                    break;
                default: Console.Write("Enter again "); break;

            } 
        }
            public void doc_serv()
            {
            string Procedure;
            decimal price;
            string idkey;

            Console.WriteLine("Choose one of the following features:");
            Console.WriteLine("1. Add ");
            Console.WriteLine("2. Remove ");
           

            Console.Write("Enter your choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("enter Procedure");
                    Procedure = Console.ReadLine();
                    Console.WriteLine("enter Procedure");
                    price = Convert.ToDecimal(Console.ReadLine());
                    p.AddProcedure(Procedure,price); break;
                case 2:
                    Console.WriteLine(" enter id  ");
                    idkey = Console.ReadLine();
                    if (!string.IsNullOrEmpty(idkey))
                    {
                        possin = p.SearchIndex(idkey);
                        p.RemoveProcedure(possin);
                    }
                    Console.WriteLine(" error ");
                    break;    
             
                default: Console.WriteLine("wrong input "); break;
            }


        }

        }
    } 
