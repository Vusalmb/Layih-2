using System;
using System.Collections.Generic;
using System.Text;

namespace Layihə2
{
    class Seat
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsFull { get; set; }

        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
            IsFull = false;
        }

        public override string ToString()
        {
            string status = IsFull ? "Full" : "Empty";
            return $"Row: {Row} Column: {Column} Status: {status}";
        }
    }
}
