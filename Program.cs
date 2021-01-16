using System;

namespace LostGamesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCounter = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine()); // 2 LostG -> 1-HeadSet
            double mousePrice = double.Parse(Console.ReadLine());  // 3 LostG -> Mouse
            double keyboardPrice = double.Parse(Console.ReadLine()); // 6 LostG -> Haedset + Mouse + 1  Keyboard
            double displayPrice = double.Parse(Console.ReadLine()); // 12 LostG -> HaedSet + Mouse + 1 Keyboard + 1 display

           // double totalCosts = 0;

            int brokenHeadsetCounter = lostGamesCounter / 2;    // find the number of broken HeadSet
            int brokenMouseCounter = lostGamesCounter / 3;
            int brokenKeyboardCounter = lostGamesCounter / 6;
            int brokenDisplayCounter = lostGamesCounter / 12;

            double totalCosts =  headsetPrice * brokenHeadsetCounter + mousePrice * brokenMouseCounter +
                                 keyboardPrice * brokenKeyboardCounter  + displayPrice * brokenDisplayCounter ;

            Console.WriteLine($"Rage expenses: {totalCosts:F2} lv.");
            

        }
    }
}
