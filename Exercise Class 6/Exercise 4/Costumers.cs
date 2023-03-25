namespace Exercise_4
{
    public class Costumers
    {
        public string Name { get; set; }
        public long CardNumber { get; set; }
        private int PinCode { get; set; }
        private decimal Balance { get; set; }

        public Costumers(string name,long cardNumber,int pinCode,decimal balance)
        {
            Name = name;
            CardNumber = cardNumber;
            PinCode = pinCode;
            Balance = balance;
        }

        public int GetPinCode()
        {
            return PinCode;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public decimal Withdrawal(decimal amount)
        {
            return Balance - amount;
        }
        public decimal AfterWithdrawal(decimal amount)
        {
            return Balance - amount;
        }

        public decimal Deposit(decimal amount)
        {
            return Balance + amount;
        }

        public decimal AfterDeposit(decimal amount)
        {
            return Balance + amount;
        }

        // dva duplikati ima na deposit i withdrawal ama probuvav so voidovi pa gi smeniv i ostanaa ne gi izbrishav svesen sum deka so edna od niv mozam da zavrsham rabota.


    }
}
