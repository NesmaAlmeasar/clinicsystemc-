using System;
namespace clinic_mor
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic(); // Create an instance of the Clinic

            while (true)
            {
                Console.WriteLine("who are");
                Console.WriteLine("1 employee --2pationt  3-secertaray ");

                Console.Write("Enter your choice: ");
               char choice = Convert.ToChar(Console.ReadLine());

                switch (choice)

                {
                    case '1': clinic.emp_serv();  break;
                    case '2': clinic.pat_serv(); break;
                    case3: clinic.doc_serv(); break;
                    default:  Console.WriteLine("wrong input ");break;
                }
            }
        }
    } }