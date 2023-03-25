namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 4
            Console.WriteLine("Exercise 4");
            /*
            Create an ATM application. A customer should be able to authenticate with card number and pin,
            and should be greeted with a message greeting them by full name.

            After that they can choose one of the following:
            1. Balance checking - This should print out the current balance of money on their account
            2. Cash withdrawal - This should try and withdraw cash from the users account and print a message.
            If it has enough it should print a success message that contains the money withdrawn,
            and the balance of money after the withdrawal
            3. Cash deposition - This should deposit cash on the account and give a message,
            with the new balance of money on the account after the deposit.
            
            In order for the ATM app to work we need Customers.
            This ATM asks for the number ( string ) of the card and searche,
            through the customers if a card like that exists. After that it asks for a pin.
            If the Pin matches that customer a welcome message is shown and the customer can now choose the options.
            
            Example:
            Welcome to the ATM app
            Please enter your card numer:
            > 1234-1234-1234-1234
            Enter Pin:
            > 4325
            Welcome Bob Bobsky!

            What would you like to do:
            Check Balance - type 1
            Cash Withdrawal - type 2
            Cash Deposit - type 3
            > 2
            You withdrew 250$. You have 400$ left on your account.
            Thank you for using the ATM app.
            
            - Bonus: The balance and pin should not be public
            - Bonus: The ATM card number to be a number instead of a string.
            The user should still input 1234-1234-1234-1234.
            - Bonus: When the Customer finishes with a transaction a question must pop up,
            if the Customer wants to do another action.
            If not it should print a goodbye message and show up the login menu again.
            -Bonus: Add an option to register a new card in the system that store:
            the customer in the system if the card number is not used for any other customer
            */

            // Costumers:
            Costumers[] costumerS = new Costumers[5];
            costumerS[0] = new Costumers("Marko Gigoski", 12345678910, 0000, 2500M);
            costumerS[1] = new Costumers("Kristina Gigoska", 01987654321, 1111, 5000M);
            costumerS[2] = new Costumers("Sofija Gigoska", 43215678910, 2222, 800M);
            costumerS[3] = new Costumers("Marjan Gigoski", 270124586910, 3333, 20000M);
            costumerS[4] = new Costumers("Kika Gigoska", 67891012345, 4444, 7500M);

            

            Console.Write("Welcome to the ATM app \nPlease enter your card number: ");
            string stringCardN = Console.ReadLine();
            long cardN;
            bool cardNumberToBool = long.TryParse(stringCardN, out cardN);

            foreach (Costumers i in costumerS)
            {
                if (i.CardNumber == cardN)
                {
                    Console.Write("Please enter your pin: ");
                    string stringPin = Console.ReadLine();
                    int pin;
                    bool pinToBool = int.TryParse(stringPin, out pin);

                    if (i.GetPinCode() == pin)
                    {
                        Console.WriteLine($"Welcome {i.Name}");

                        Console.WriteLine("What would you like to do: \n 1.Check Balance - type 1 \n 2.Cash Withdrawal - type 2 \n 3.Cash Deposit - type 3 \n 4.Register a new card - type 4 \n 5.Exit the app - type 5");
                        string choise = Console.ReadLine();

                        switch (choise)
                        {
                            case "1":
                                Console.WriteLine($" Your curent balance is: {i.GetBalance()}");
                                break;
                            case "2":
                                Console.WriteLine($"Your current balance is: {i.GetBalance()}");

                                Console.Write("How much would you like to withdrawal: ");
                                string stringAmaountWithdrawal = Console.ReadLine();
                                decimal amountWithdrawal;
                                bool withdrawalToBool = decimal.TryParse(stringAmaountWithdrawal, out amountWithdrawal);

                                i.Withdrawal(amountWithdrawal);
                                
                                Console.WriteLine($"You have seccessfuly withdrawal {amountWithdrawal}. \n You have {i.AfterWithdrawal(amountWithdrawal)} left on your bank acc. \n Thank you for using the ATM app!");
                                break;
                            case "3":
                                Console.WriteLine($"Your current balance is: {i.GetBalance()}");

                                Console.Write("How much would you like to deposite on your acc: ");
                                string stringDeposit = Console.ReadLine();
                                decimal amountDeposit;
                                bool depositToBool = decimal.TryParse(stringDeposit, out amountDeposit);

                                i.Deposit(amountDeposit);

                                Console.WriteLine($" You have seccessfuly deposit {amountDeposit}, your current balance is: {i.AfterDeposit(amountDeposit)}");
                                break;
                            case "4":
                                Console.Write("Enter your full name: ");
                                string newFullName = Console.ReadLine();

                                Console.Write("Enter your card number: ");
                                string stringCardNumber = Console.ReadLine();
                                long cardNumber;
                                bool cardToBool = long.TryParse(stringCardNumber, out cardNumber);

                                Console.Write("Enter your 4 digit pin: ");
                                string stringNewPin = Console.ReadLine();
                                int newPin;
                                bool newPinToBool = int.TryParse(stringNewPin, out newPin);

                                Console.WriteLine($"Whould you like to deposite some amount to your ne card? \n Yes - type 1 \n No - type 2");
                                string choise2 = Console.ReadLine();

                                if(choise2 == "1")
                                {
                                    Console.Write("How much will you deposit: ");
                                    string lastDeposit = Console.ReadLine();
                                    decimal deposit;
                                    bool lastDepositToBool = decimal.TryParse(lastDeposit, out deposit);

                                    Costumers newCostumer = new Costumers(newFullName, cardNumber, newPin, deposit);
                                    Array.Resize(ref costumerS, costumerS.Length + 1);
                                    costumerS[costumerS.Length - 1] = newCostumer;

                                    Console.WriteLine($"Costumer {newCostumer.Name} with card Number {newCostumer.CardNumber} has been seccessesfuly created");
                                }
                                else if(choise2 == "2")
                                {
                                    Costumers newCostumer = new Costumers(newFullName, cardNumber, newPin, 0m);
                                    Array.Resize(ref costumerS, costumerS.Length + 1);
                                    costumerS[costumerS.Length - 1] = newCostumer;

                                    Console.WriteLine($"Costumer {newCostumer.Name} with card Number {newCostumer.CardNumber} has been seccessesfuly created");
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input, start all over again!");
                                }
                                break;
                            case "5":
                                Console.WriteLine("Have a great day.");
                                return;
                        }

                    }
                    else
                    {
                        Console.WriteLine($"You have entered a wrong pin number. Start all over again.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered a wrong card number, try again latter");
                    return;
                }
            }

            // Bonus: When the Customer finishes with a transaction a question must pop up, if the Customer wants to do another action.

            // Neznaev kako da go ubacam vo swich so continiun da dava pak od loopot da prashuva edno od 5-te opcii da izbere, deka neli mora break da ima itn.
            // I mislam deka so scopovite imam nekoj grehski zosto nema da se zachuvaat nekoj informacii zosto se vo loopovi, mada ke mi kazete vie najdobro kako podobro vo site segmenti:)

        }
    }
}