using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank;

public class InterestEarningAccount : BankAccount
{
    //Derived Constructor
    public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
    {
    }

    //Apply Month End Interest
    public override void PerformMonthEndTransactions()
    {
        if (Balance > 500m)
        {
            decimal interest = Balance * 0.05m;
            MakeDeposit(interest, DateTime.Now, "apply monthly interest");
        }
    }
}
/// <summary>
/// </summary>