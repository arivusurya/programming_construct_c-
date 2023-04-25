using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Program_construct{
    public class Loops {

        public void Powof2(){
            Console.WriteLine("Enter the Number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++){
                double Powof2 = Math.Pow(i,2);

                if(Powof2 < Math.Pow(N,2)){
                    Console.WriteLine(Powof2);
                }
            }
        }

        public void Factorial(){
            int Factorial =1 ;
            Console.WriteLine("Enter the Number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            

            for (int i = N; i >=1; i--){
                Factorial = Factorial * i;
            }

            Console.WriteLine(Factorial);
        }

        public void SumofSquares(){
            Console.WriteLine("Enter the Number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int SumofSquares = 0;

            for (int i = 1; i <=N ; i++){
                SumofSquares += i * i ;
                
            }
            Console.WriteLine(SumofSquares);
        }
    }
}