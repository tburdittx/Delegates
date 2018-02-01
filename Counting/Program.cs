using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Counting.Apples;


namespace Counting
{

    class Program
    {
        public static int RedCount = 0;
        public static int GreenCount = 0;

      static  List<Apples> BoxOfApple = new List<Apples>();
        public delegate void CountingApples(int Count); //Creating arguements for the delegate
        public delegate int CountTheRedApples(int CountRed);


        static void Main(string[] args)
        {

            Cart cart = new Cart();
            Counter counter = new Counter();

            BoxOfApple.Add(new Apples() { colour = Colour.Green });
            BoxOfApple.Add(new Apples() { colour = Colour.Green });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });

            Box<Apples> box = new Box<Apples>();
            box.Add(BoxOfApple);

            //Creating a method for the delegate

            void AppleCounter(int Count)  //method for counting all apples
            {
                Console.WriteLine($"Apples in box: {box.Count()}");
            }

            Action action = RedMethod;
         
            Counter.RedCounter(RedMethod);

            //Instantiating the delegate
            CountingApples handler = AppleCounter;

            //Calling the delegate 
            handler(box.Count());  //Counting all apples            

            Console.ReadLine();
        }
        static void RedMethod()
        {
            int ColourCounter(int CountRed)
            {
                foreach (Apples apple in BoxOfApple)
                {
                    if (apple.colour == Colour.Red)
                    {
                        RedCount++;
                    }
                }

                Console.WriteLine($"Amount of Red Apples: {RedCount}");
                return RedCount;
            }
            CountTheRedApples theRedApples = ColourCounter;
            theRedApples(RedCount); //Counting just red apples
        }
    }
    class Counter
    {
        public static void RedCounter(Action CountReds)
        {
            CountReds();
        }
        public static int CountReds()
        {
            int TheRedCounter = 0;
            TheRedCounter++;
            return TheRedCounter;
        }
    }
}
