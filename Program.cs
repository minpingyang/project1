using System;

namespace project2
{
    class A
    {
        private int x;
        public int XX
        {
            get { return x; }
            set { x = 8; }
        }
    }
    class B{
        private int y;
        public int YY{
            get { return y; }
            set { y = value; }
        }
    }





}
namespace interfaceExample{
    namespace interfaceApplication{
        public interface ITransaction{
            void showTransaction();
            double getAmount();
        }
        public class Transaction:ITransaction{
            private string tCode;
            private string date;
            private double amount;
            public Transaction(){
                tCode = " ";
                date = " ";
                amount = 0.0;
            }
            public Transaction(string c, string d, double a){
                tCode = c;
                date = d;
                amount = a;
            }
            public double getAmount(){
                return amount;
            }
            public void showTransaction(){
                Console.WriteLine("Transaction: {0}",tCode);
                Console.WriteLine("Date: {0}", date);
                Console.WriteLine("Amount:{0}",getAmount());
            }

        }
        class Tester{
            static void Main(string[] args){
                Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
                Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
                t1.showTransaction();
                t2.showTransaction();
            }


        }
    }
}

namespace project1
{
    

    abstract class FourLeggedAnimal {
        public virtual string Describe(){
            return "The animal has for legs";
        }

    }
    class Dog:FourLeggedAnimal{
		public override string Describe()
		{
            return "The four legged animal is a Dog!";
		}
	}

    class MainClass
    {
        //public static void Main(string[] args)
        //{

        //    //new MainClass().firstDraw();
        //    //new MainClass().secondDraw();
        //    Dog dog = new Dog();
        //    FourLeggedAnimal.

        //    Console.WriteLine(dog.Describe());
        //}

        public void firstDraw()
        {
            for (int row = 0; row < 10; row++)
            {

                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public void secondDraw()
        {
            for (int row = 0; row < 10; row++)
            {

                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write('*');

                }

                for (int i = 0; i < 2 * (10 - (row + 1)); i++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < row + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }

}
