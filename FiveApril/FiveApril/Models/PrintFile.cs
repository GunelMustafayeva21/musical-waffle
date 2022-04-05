using System;
using System.Collections.Generic;
using System.Text;

namespace FiveApril.Models
{
    static class PrintFile 
    {
        

        public static void Print(IPrintable file)
        {
            file.Print();
        }
        
    }
}
