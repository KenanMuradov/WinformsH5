using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsH5.Models;

public class Operation
{
    public DateTime OperationDate { get; set; }
    public double PaidMoney { get; set; }
    public double ReturnedMoney { get; set; }
    public List<string>? BoughtProducts { get; set; }

    public Operation(DateTime operationDate, double paidMoney, double returnedMoney, List<string>? boughtProducts)
    {
        OperationDate = operationDate;
        PaidMoney = paidMoney;
        ReturnedMoney = returnedMoney;
        BoughtProducts = boughtProducts;
    }


}
