using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_mor
{
    public abstract class person
    {

        public static int ID_count;

        protected List<string> ID = new List<string>();
        protected List<string> name = new List<string>();
        protected List<int> age = new List<int>();
        protected List<string> phone = new List<string>();
        protected List<string> gender = new List<string>();
        protected List<double> count = new List<double>();

        public virtual void AddPerson()
        {
            string input;
            int inputInt =0;
            if(ID.Count > 0 && ID.Count< ID_count) { 
            Console.WriteLine("Name:");
            input = Console.ReadLine();
            name.Add(input);

            Console.WriteLine("Age:");
            if (int.TryParse(Console.ReadLine(), out inputInt))
            {
                age.Add(inputInt);
            }
            else
            {
                Console.WriteLine("Invalid input for age");
            }

            Console.WriteLine("Phone:");
            input = Console.ReadLine();
            phone.Add(input);

            Console.WriteLine("Gender:");
            input = Console.ReadLine();
            gender.Add(input);
            input = Convert.ToString(ID_count);
            IDGenerator g = new IDGenerator();
            input = g.generate();
            ID.Add(input);
                inputInt=ID.Count+1;
            Console.WriteLine(  "your id is " +ID[inputInt]);

            count.Add(0);


            ID_count++;
                }
        }
        public virtual void RemovePerson(int index)
        {
            if (index >= 0 && index < ID_count)
            {
                ID.RemoveAt(index);
                name.RemoveAt(index);
                age.RemoveAt(index);
                gender.RemoveAt(index);
                phone.RemoveAt(index);
                count.RemoveAt(index);
                ID_count--;
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        public void PrintList()
        {
            if (ID_count > 0)
            {
                for (int i = 0; i < ID_count; i++)
                {
                    Console.WriteLine("Name: {0}, ID: {1}, Age: {2}", name[i], ID[i], age[i]);
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        public  void Edit()
        {
            if (ID_count > 0)
            {
                Console.WriteLine("Enter ID of the person to edit:");
                string keyID = Console.ReadLine();
                int searchIndex = SearchIndex(keyID);
                if (searchIndex >= 0)
                {
                    RemovePerson(searchIndex);
                    AddPerson();
                }
                else
                {
                    Console.WriteLine("Person not found");
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
        public int SearchIndex(string keyID)
        {
            int index = 0;
            for (int i = 0; i < ID_count; i++)
            {
                if (ID[i] == keyID)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public virtual void PrintInfo(int index)
        {
            if (index >= 0 && index < ID_count)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Phone: {2}, Gender: {3}", name[index], age[index], phone[index], gender[index]);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

    }

    }
