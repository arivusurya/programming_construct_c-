﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using programming_construct;

namespace Program_construct{

    public class Program{
        public static void Main(string[] args)
        {
            Construct obj = new Construct();
            obj.oddoreven(4);
            System.Console.WriteLine(obj.iseligibleforvote(17)); 
        }
    }

}