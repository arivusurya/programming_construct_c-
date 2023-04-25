using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Program_construct{
    public class  ConditionalClass{

        public void GreatestAmoungThree(int Num1,int Num2,int Num3){
            if(Num1 > Num2 && Num1 > Num3){
                Console.WriteLine($"{Num1} is greater than {Num2} and {Num3}");
            }else if(Num2 > Num3){ 
                Console.WriteLine($"{Num2} is greater than {Num3} and {Num1} ");
            }else{
                System.Console.WriteLine($"{Num3} is greater than {Num1} and {Num2}");
            }
        }

        // helper funtion for adding three NUmber :

        private int AddMarks(int Mark1,int Mark2,int Mark3){
            return (Mark1 + Mark2 + Mark3);
        }

        public void AddmisionEligible(){
            Console.WriteLine("Input the mark obtained from Math: ");
            int Math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the mark obtained from Physics: ");
            int Physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the mark obtained from Chemistry: ");
            int Chemestry = Convert.ToInt32(Console.ReadLine());

            if(Math >=65 && Physics >=55 && Chemestry >=50){
                if( AddMarks(Math,Physics,Chemestry)>=180){
                Console.WriteLine("Canditate is Eligible for addmissions");
                }else if(Math+Physics >=140 || Math+Chemestry >= 140){
                   Console.WriteLine("Canditate is Eligible for addmissions"); 
                }else{
                    Console.WriteLine("Canditate is Not Eligible for addmissions");
                }
            }else{
                Console.WriteLine("Canditate is Not Eligible for addmissions");
            }
        }

    }
}