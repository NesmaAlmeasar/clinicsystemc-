using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_mor
{
    class Patient : person
    {
        List<string> procedures = new List<string>();
        List<decimal> procedurePrices = new List<decimal>();
        public override void AddPerson()
        {
            base.AddPerson();
            procedures.Add(" ");
            procedurePrices.Add(0);
        }

        public override void RemovePerson(int index)
        {
            base.RemovePerson(index);
            procedures.RemoveAt(index); 
            procedurePrices.RemoveAt(index);
        }

        public override void PrintInfo(int index)
        {
            base.PrintInfo(index);
            if (index >= 0 && index < ID_count)
            {
                Console.WriteLine("procedures[0]  procedurePrices[1] ", procedures[index], procedurePrices[index]);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        public void AddProcedure(string procedure, decimal price)
        {
            procedures.Add(procedure);
            procedurePrices.Add(price);
        }
        public void RemoveProcedure(int index)
        {
            if (index >= 0 && index < procedures.Count)
            {
                procedures.RemoveAt(index);
                procedurePrices.RemoveAt(index);
            }
        }
    }
}
