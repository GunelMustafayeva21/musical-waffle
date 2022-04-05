using System;
using System.Collections.Generic;
using System.Text;

namespace FiveApril.Models
{
    class PDF : IPrintable
    {
        
        public int PageCount { get; set; }
        public string FileName { get ; set; }

        public PDF(string FileName, int PageCount)
        {
            this.FileName = FileName;
            this.PageCount = PageCount;
        }

        public void Print()
        {
            Console.WriteLine($" {FileName} Printed. PageCount {PageCount}  ");
        }
    }
}
