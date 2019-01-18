using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shipping Rates ###

            //setup
            double inputpounds = 0.0;
            double shippingrate = 0.0;
            double firstlevel = 2.0;
            double firstcost = 2.0;
            double secondlevel = 6.0;
            double secondcost = 4.0;
            double thirdlevel = 10.0;
            double thirdcost = 6.0;
            double fourthcost = 8.0;
            string tempnum = string.Empty;
            bool isNumeric = false;


            //input
            do
            {
                Console.WriteLine("What is the weight of your package?");
                tempnum = Console.ReadLine();
                isNumeric = double.TryParse(tempnum, out double n);
                if (isNumeric == false || double.Parse(tempnum) <= 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    isNumeric = false;
                }

            } while (isNumeric == false);
            inputpounds = double.Parse(tempnum);


            //processing
            if (inputpounds < firstlevel)
                shippingrate = firstcost;
            else if (inputpounds < secondlevel)
                shippingrate = secondcost;
            else if (inputpounds < thirdlevel)
                shippingrate = thirdcost;
            else
                shippingrate = fourthcost;


            //output
            Console.WriteLine("The shipping cost is " + shippingrate);
            Console.ReadLine();
        }

    }
}

