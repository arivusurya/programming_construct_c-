using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Program_construct{
    public class WhileLoop {

        public void CoinFlip(){
            Random random = new Random();
            int Head = 0 ;
            int Tail = 0 ;

            while (Head < 20 && Tail < 20){
                int coincheck = random.Next(0,2);

                if(coincheck == 0){
                    Head++;
                }else{
                    Tail++;
                }
            }

            Console.WriteLine("Head: " + Head + " Tail: " + Tail);
        }

        public void ReverseString(){
            Console.Write("Enter the string to reverse : ");
            String Word = Console.ReadLine();
            int i = Word.Length -1;

            while(i>=0){
                Console.WriteLine(Word[i]);
                i--;
            }

        }

        public void SumofFive(){
            int n =5;
            int i =1;
            int sum = 0 ;

            while(i <=n){
                sum += i;
                i++;
            }
            Console.WriteLine("Sum: " + sum);

        }
    }
}