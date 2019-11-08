using System;
using System.Collections.Generic;

namespace Cash_Register
{
    class Program 
    {

        public static void Main(string[] args)
        {
            
  
            string cont = "n";
            char ch;
            string skuNum;
            float asp = .97f;
            float bananas = 0;
            float cake = 3.88f;
            float eggs = 1.89f;
            float pasta = 3.29f;
            float potatoes = 0;
            float soup = 2.99f;
            float tax = .07f;
            float sum = 0f;
            float total = 0f;


            //Cart prices = new Cart();



            while (cont == "n")
            {
                Console.WriteLine("Fresh Foods\n" +
                "Grocery List:");
                Console.WriteLine("Enter a: for Asparagus $.97");
                Console.WriteLine("Enter 2121: for Bananas $1.07 per LB");
                Console.WriteLine("Enter c: for Cake $3.88");
                Console.WriteLine("Enter e: for Eggs $1.89");
                Console.WriteLine("Enter p: for Pasta $3.29");
                Console.WriteLine("Enter 5150: for Potatoes $1.67 per LB");
                Console.WriteLine("Enter s: for Soup $2.99");
                Console.WriteLine($"Total:{sum}");
                Console.WriteLine("Enter an item (Enter m for SKU #)");
                
                ch = Console.ReadLine()[0];
                ch = char.ToLower(ch);
                if (ch == 'm')
                {
                    Console.WriteLine("Enter SKU#");
                    skuNum = Console.ReadLine();
                    switch (skuNum)
                    {
                        case "2121":
                            Console.WriteLine($"Enter weight in LB:");
                            float weight = float.Parse(Console.ReadLine());
                            float sub = 0;
                            sub = weight * 1.07f;
                            bananas += sub;
                            sum += bananas;
                            Console.WriteLine(sum);

                            break;
                        case "5150":
                            Console.WriteLine($"Enter weight in LB:");
                            float weight1 = float.Parse(Console.ReadLine());
                            float sub1 = 0;
                            sub1 = weight1 * 1.67f;
                            potatoes += sub1;
                            sum += potatoes;
                            Console.WriteLine(sum);

                            break;
                    }
                }

                switch (ch)
                {
                    case 'a':
                        sum += asp;
                        Console.WriteLine(sum);

                        break; 
                    case 'c':
                        sum += cake;
                        Console.WriteLine(sum);

                        break;
                    case 'e':
                        sum += eggs;
                        Console.WriteLine(sum);

                        break;
                    case 'p':
                        sum += pasta;
                        Console.WriteLine(sum);

                        break;
                    case 's':
                        sum += soup;
                        Console.WriteLine(sum);

                        break;
                    

                }
                Console.WriteLine("Add another item? Y or N");
                string aa = Console.ReadLine();
                aa.ToLower();
                if (aa == "n")
                    cont = "y";
                else
                    Console.Clear();

            }
            total = sum;
            sum *= tax;
            total += sum;
            Console.WriteLine($"Tax:$0.07\n" +
                $"The grand total is {total}");
        }
    }
}