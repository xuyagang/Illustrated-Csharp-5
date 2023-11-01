using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_26_16_switch模式匹配
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStock = new Stock() { Name = "Tesla", MinPurchaseAmt = 100 };
            var myBond = new Bond() { Name = "California", MinPurchaseAmt = 500 };
            var myBankAccount = new BankAccount() { Name ="Abc Bank", MinPurchaseAmt = 10 };
            var myBankAccount2 = new BankAccount() { Name = "Xyz Bank", MinPurchaseAmt = 20 };
            var myRealEstate = new RealEstate() { Name = "My Vacation", MinPurchaseAmt = 100000 };

            CheckInvestmentType(myStock);
            CheckInvestmentType(myBond);
            CheckInvestmentType(myBankAccount);
            CheckInvestmentType(myBankAccount2);
            myBankAccount2 = null;
            // myBankAccount2为null时，不会匹配 BankAccount bankAccount情况
            CheckInvestmentType(myBankAccount2);
            // 如果没找到会触发default
            CheckInvestmentType(myRealEstate);
        }

        public static void CheckInvestmentType(Investment investment)
        {
            switch (investment)
            {
                case Stock stock:
                    WriteLine($"This investment is a stock named {stock.Name}");
                    break;
                case Bond bond:
                    WriteLine($"This investment is a bond named {bond.Name}");
                    break;
                case BankAccount bankAccount when bankAccount.Name.Contains("Abc"):
                    WriteLine($"This investment is my Abc Bank account");
                    break;
                case BankAccount bankAccount:
                    WriteLine($"This investment is any bank account other than Abc Bank");
                    break;
                case null:
                    WriteLine($"For whatever reason, this investment is null");
                    break;
                default:
                    WriteLine($"The default case will always be evaluated last.");
                    WriteLine($"Even if its position is not last.");
                    break;
            }
        }
    }

    public abstract class Investment
    {
        public string Name { get; set; }
        public double MinPurchaseAmt { get; set; }
    }

    public class Stock : Investment { }
    public class Bond : Investment { }
    public class BankAccount : Investment { }
    public class RealEstate : Investment { }

}
