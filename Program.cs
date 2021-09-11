using System;

namespace PagBan
{
    public class PagBank
    {

        private readonly string _customerName;
        private double _balance;
        private double _tax = 1.50;
        private double _taxCredit = 1.80;

        private PagBank() { }

        public PagBank(string customerName, double balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public string CustomerName
        {
            get { return _customerName; }
        }

        public double Balance
        {
            get { return _balance; }
        }


        public void Debit(double amount)
        {
            if(amount > _balance)
            {
                _balance -= _tax * amount;
            }
            else if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            else
            {
                _balance -= amount;
            }
        }

        public static void Main()
        {
            PagBank ba = new PagBank("Joaquim", 20.50);

            ba.Debit(30);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}
