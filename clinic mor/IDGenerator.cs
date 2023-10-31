using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_mor
{
    class IDGenerator
    {
        static int id = 0;
        string storeId;
        DateTime date = DateTime.Now;

        public string generate()
        {
            string gid = DateTime.Now.ToString("yyyy-MM-");
            storeId = gid + ++id;

            return storeId;

        }

    }
}
