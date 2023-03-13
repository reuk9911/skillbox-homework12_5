using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_5
{
    public class Client
    {
        private static int NextId;

        public string Name { get; }

        public int Id { get; }

        public List<int> Bills { get; }

        static Client()
        {
            NextId = 0;
        }
        public Client(string Name)
        {
            this.Name = Name;
            this.Id = NextId++;
            this.Bills = new List<int>();
        }
}
