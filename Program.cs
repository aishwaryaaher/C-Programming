using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMMachineProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int Amt = 10000, a, current, pin = 4040, pin1, pin2;
            Console.WriteLine("Enter the pin ");
            pin1 = int.Parse(Console.ReadLine());
           
            if(!(pin==pin1))
            {
                Console.WriteLine("You Enter Wrong pin please try again>>>>>>>>>>>>>>>>");
            }
            else if()
            {
                Console.WriteLine(" ");
            }

            else(pin == pin1)
            {
                Console.WriteLine("1.To Check Balance");
                Console.WriteLine("2.To Withdraw Money");
                Console.WriteLine("3.To deposite Money");
                Console.WriteLine("4.To change pin ");
                Console.WriteLine("Enter your Choice");

                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("The current balance is in your account is" + Amt);
                        break;


                    case 2:
                        Console.WriteLine("Enter the Amount to withdraw");
                        {
                            a = int.Parse(Console.ReadLine());
                            if (Amt >= a)
                            {
                                if (a % 100 == 0)
                                {
                                    Console.WriteLine("Please collect the cash" + a);
                                    current = Amt - a;
                                    Console.WriteLine("The Current balance is now" + current);
                                }
                                else

                                    Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");

                            }
                            else

                                Console.WriteLine("Your Account does not have sufficient balance");

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount to be deposite");
                        a = int.Parse(Console.ReadLine());
                        current = Amt + a;
                        Console.WriteLine(" The Current balance in the account is " + current);
                        break;


                    case 4:
                        Console.WriteLine("Want to change your pin");
                        Console.WriteLine("enter your Previous pin");
                        int prepin = int.Parse(Console.ReadLine());
                        if (prepin == pin)
                        {
                            Console.WriteLine("Enter your new pin");
                            pin2 = int.Parse(Console.ReadLine());
                            pin1 = pin2;
                            Console.WriteLine("Yor pin is changed");

                        }
                        else Console.WriteLine("Enter your correct pin ");
                        break;

                    default:
                        Console.WriteLine("Pleae select correct option");
                        break;

                }
            }

           
        }
    }
}