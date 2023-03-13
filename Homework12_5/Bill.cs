using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_5
{
    public class Bill
    {
        private static int NextId;

        public int ClientId { get; }

        public float Sum { get; set; }

        public int Id { get; }

        static Bill()
        {
            NextId = 0;
        }

        public Bill(int ClientId, float Sum)
        {
            this.ClientId = ClientId;
            this.Sum = Sum;
            this.Id = NextId++;
        }





    }
}
