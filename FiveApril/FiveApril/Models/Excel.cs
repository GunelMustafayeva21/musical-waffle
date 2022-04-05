using System;
using System.Collections.Generic;
using System.Text;

namespace FiveApril.Models
{
    class Excel :  IPrintable
    {
         public string  FileName { get; set; }
        public int ColumnCount { get; set; }

        public int RowCount { get; set; }
        public Excel(string FileName, int ColumnCount, int RowCount)
        {
            this.FileName = FileName;
            this.ColumnCount = ColumnCount;
            this.RowCount = RowCount;
        }
        public void Print()
        {
            Console.WriteLine($" {FileName} Printed. ColumnCount {ColumnCount} and RowCount {RowCount} ");
        }
    }
}
