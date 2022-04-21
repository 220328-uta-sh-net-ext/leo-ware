using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank;

public  class GiftCardAccount : BankAccount
{
    //Gift Card Construction
    private readonly decimal _monthlyDeposit = 0m;

    public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
        => _monthlyDeposit = monthlyDeposit;

    //Add Monthly Deposit
    public override void PerformMonthEndTransactions()
    {
        if (_monthlyDeposit != 0)
        {
            MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
        }
    }
}
