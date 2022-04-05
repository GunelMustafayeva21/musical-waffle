using FiveApril.Models;
using System;

namespace FiveApril
{
    class Program
    {
        static void Main(string[] args)
        {

            Word word = new Word("FirstDoc", 256);
            PDF pdf = new PDF("FirstPdf", 20);
            Excel excel = new Excel("FirstExcel", 10, 20);

            PrintFile.Print(word);
            PrintFile.Print(pdf);
            PrintFile.Print(excel);

        }
    }

    public interface IPrintable
    {
        public string FileName { get; set; }
        void Print()
        {
            
        }
    }
}
