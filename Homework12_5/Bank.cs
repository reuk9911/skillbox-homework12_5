using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_5
{
    public class Bank
    {
        public ObservableCollection<Client> Clients { get; }
        public ObservableCollection<Bill> Bills { get; }
        public void Transfer(int BillId1, int BillId2) { }
        public void OpenBill(int ClientId, ) { }
        public void CloseBill(int ClientId) { }
        public void DepositCash(int BillId, float Sum) { }
        public void AddClient() { }
    }
}
