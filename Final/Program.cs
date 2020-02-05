using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Much Candy? Let's get the conditions.");
            Console.WriteLine("What's the temp like? enter 40, 50, 60 or 70");
            double temp = Double.Parse(Console.ReadLine());

            Console.WriteLine("And the weather? enter \"Clear\", \"Cloudy\", \"Raining\", or \"Full Moon\" ");
            string weather = Console.ReadLine();

            double candycount = HowMuchCandy(temp, weather);

            Console.WriteLine("You should buy" + candycount + "pieces of candy.");
        }
         static double HowMuchCandy(double temp, string weather)
        {
            double kids = 250;
            
            switch(temp)
            {
                case 40:
                    kids = kids - (kids * .05);
                    break;
                case 50:
                    break;
                case 60:
                    kids = kids + (kids * .05);
                    break;
                case 70:
                    kids = kids - (kids * .2);
                    break;
            }
            
            switch(weather)
            {
                case "Clear":
                    kids = kids + (kids * .1);
                    break;
                case "Cloudy":
                    break;
                case "Raining":
                    kids = kids - (kids * .25);
                    break;
                case "Full Moon":
                    kids = kids + (kids * .25);
                    break;
            }

            return kids*3;
        }
    }
}
