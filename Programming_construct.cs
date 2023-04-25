using System;
namespace programming_construct

{
    public class Construct
    {
        

        public  void equalornot(int x, int y){

            if(x == y){
                Console.WriteLine("The Given two numbers are equal");
            }else{
                Console.WriteLine("The Two numbers are not equal");
            }

        }

        public void oddoreven(int Number){
            if(Number % 2 == 0){
                Console.WriteLine($"The Given {Number} is an Even Number");
            }else{
                Console.WriteLine($"The Given {Number} is an Odd Number");
            }

        }

        public bool iseligibleforvote(int Age){
            bool eligible = false;

            if(Age >= 18){
                 eligible = true; 
            }

            return eligible;

        }

    }
}