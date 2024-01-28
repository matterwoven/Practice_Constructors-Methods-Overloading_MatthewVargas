using System.ComponentModel.DataAnnotations;

namespace Practice_Constructors_Methods_Overloading_MatthewVargas
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // Car information
            CarsAndMath.Car defaultCar = new CarsAndMath.Car();
            CarsAndMath.Car makeModel = new CarsAndMath.Car("Toyota", "Rav4");
            CarsAndMath.Car fullCar = new CarsAndMath.Car("Hyundai", "Sonata", 2010, 100000);
            //Different Car classes created
            Console.WriteLine("Car information");
            Console.WriteLine(defaultCar);
            Console.WriteLine(makeModel);
            Console.WriteLine(fullCar);
            //Writing to console Car class information
            Console.WriteLine();
            //Seperator
            Console.WriteLine("Bank Transaction Information");
            // Bank Information
            CarsAndMath.BankAccountMath.AccountLogic accountLogic = new CarsAndMath.BankAccountMath.AccountLogic("12345", "Will Cram", 1900);
            Console.WriteLine(accountLogic);
            accountLogic.Deposit(200);
            Console.WriteLine(accountLogic);
            accountLogic.Deposit(-1500);
            Console.WriteLine(accountLogic);
            accountLogic.Withdraw(3000);
            //--------\\
            //Console.WriteLine(accountLogic);
            //accountLogic.Deposit(-500);
            //Console.WriteLine(accountLogic);
            //accountLogic.Deposit(1700);
            //--------\\
            //Above are extra examples you can enable to test

        }
    }
}
