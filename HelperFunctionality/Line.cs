using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunctionality
{
    public class Line
    {
        Point Start, End;

        public Line()
        {
            Start = End = new Point();
        }
        public Line(Point start , Point end)
        {
            Start = start;
            End = end;
        }

        public void DrawLine(Graphics g)
        {
            Pen myPen = new Pen(Color.Blue ,2 );
            g.DrawLine(myPen, Start, End);
        }
    }
}
