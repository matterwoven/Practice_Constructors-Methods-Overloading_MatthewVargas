using System;

namespace Practice_Constructors_Methods_Overloading_MatthewVargas
{
    public class CarsAndMath
    {
        public class Car
        {
            string accnumber = "unassigned";
            string accname = "unassigned";
            string accbalance = "unassigned";
            string _make = "unassigned";
            string _model = "unassigned";
            int _year = 0;
            int _mileage = 0;

            // Default constructor
            public Car()
            {

            }

            // Constructor for new car
            public Car(string make, string model)
            {
                this._make = make;
                this._model = model;
                this._year = 0;
                this._mileage = 0;
            }

            // Constructor for full car information
            public Car(string make, string model, int year, int mileage)
            {
                this._make = make;
                this._model = model;
                this._year = year;
                this._mileage = mileage;
            }

            // Properties
            public string Make => _make;
            public string Model => _model;
            public int Year => _year;
            public int Mileage => _mileage;

            // Override ToString()
            public override string ToString()
            {
                    return $"{_year} {_make} {_model} - Mileage {_mileage}";
            } // Again ToString being a great tool here
        }
        public class BankAccountMath
        {
            public class AccountLogic
            {
                private int balance;
                private int balanceresult = 0;
                private string accnumber;
                private string accname;
                //Setting values for account logic so it doesn't break on me

                public AccountLogic(string accnumber, string accname, int accbalance)
                {
                    balance = accbalance;
                    balanceresult = 0;
                    this.accnumber = accnumber;
                    this.accname = accname;
                }

                public void Deposit(double amount)
                {
                    if (amount >= 0)
                    {
                        balanceresult = (int)(amount + balance);
                        Console.WriteLine($"New Balance: ${balanceresult}");
                        //Checking for valid input, if valid response is true then displays the result with informative text
                    }
                    else
                    {  //Was it necesarry? No, but I guess it's a nice element
                        Console.WriteLine("Invalid amount.");
                    }
                }
                public void Withdraw(double amount)
                {

                    if (amount >= 0)
                    {
                        balanceresult = (int)(balance - amount);
                        if (balanceresult >= 0)
                        {
                            balanceresult = (int)(balance - amount);
                            Console.WriteLine($"New Balance: ${balanceresult}");
                            //standard, pretty much deposit with subtraction and an extra if statement
                        }
                        else
                        {  //Copied from above after adding withdraw method
                            Console.WriteLine("Invalid amount.");
                        }
                    }
                    else
                    {  //Ditto the last comment
                        Console.WriteLine("Invalid amount.");
                    }
                }

                public void AccountCreated()
                {
                    //Never ended up using this, but something to build off of in the future if needed
                }

                public override string ToString()
                {
                    return $"{accnumber} - {accname} - Current Balance: ${balance}";
                }
                // ToString saved my butt here
            }
        }
    }
}