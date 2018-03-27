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
        public static void Main(string[] args)
        {

            //new MainClass().firstDraw();
            //new MainClass().secondDraw();
            Dog dog = new Dog();
            FourLeggedAnimal.

            Console.WriteLine(dog.Describe());
        }

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
