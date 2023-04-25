using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Program_construct{
    class SwitchCase{

        public void WeekName(){
             int dayNum  ;
            Console.WriteLine("Enter the name of weekday Number ");
             dayNum = Convert.ToInt32(Console.ReadLine());

            switch(dayNum){
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;   
            }
        
        }


        public void Calci(){
            Console.WriteLine("Enter the first Number: ");
            int Num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            int Num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Option: ");
            Console.WriteLine("1 : Addition");
            Console.WriteLine("2 : Subtract"); 
            Console.WriteLine("3 : multiply");
            Console.WriteLine("4 : Divide");

            int Option = Convert.ToInt32(Console.ReadLine());

            switch(Option){
                case 1:
                    Console.WriteLine(Num_1+Num_2);
                    break;
                case 2:
                    Console.WriteLine(Num_1 - Num_2);
                    break;
                case 3:
                    System.Console.WriteLine(Num_1 * Num_2);
                    break;
                case 4:
                    System.Console.WriteLine(Num_1/Num_2);
                    break;
                default:
                    Console.WriteLine("Enter the correct Option !");
                    break;
            }


        }



    }
}