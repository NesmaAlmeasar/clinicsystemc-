using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_mor
{
    public class employee : person
    {
        List<int> workHours = new List<int>();
        List<double> hourlyRate = new List<double>();
        const float minRate = 100;
        public override void AddPerson()
        {
            base.AddPerson();
            workHours.Add(0);
            hourlyRate.Add(0);
        }
        public override void RemovePerson(int index)
        {
            base.RemovePerson(index);
            workHours.RemoveAt(index);
            hourlyRate.RemoveAt(index);
        }
        public override void PrintInfo(int index)
        {
            base.PrintInfo(index);
            if (index >= 0 && index < ID_count)
            {
                Console.WriteLine("you have to work [0]  and you will take [1] ", workHours[index], workHours[index]* hourlyRate[index]);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

    }
   
   
}
