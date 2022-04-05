using System;
using System.Collections.Generic;
using System.Text;

namespace FiveApril.Models
{
    class Word :  IPrintable
    {
        public string FileName { get; set; }
        public int WordCount { get; set; }
        public Word(string FileName, int WordCount)
        {
            this.FileName = FileName;
            this.WordCount = WordCount;
        }
        public void Print()
        {
            Console.WriteLine($" {FileName} Printed. WordCount {WordCount}  ");
        }
    }
}
