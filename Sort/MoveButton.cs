using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public class MoveButton:Button
    {
        public MoveButton() : base()
        {
            Width = 60;
            Height = 60;
        }

        public MoveButton(int x, int y) : this()
        {
            Left = x;
            Top = y;
        }

        public void swapMove(int x, int y)
        {
            Thread.Sleep(300);
            if (Left > x)
            {
                Thread.Sleep(200);
                while (Left != x)
                    Left--;
            }
            else
            {
                Thread.Sleep(200);
                while (Left != x)
                    Left++;
            }
            if(Top > y)
            {
                Thread.Sleep(200);
                while (Top != y)
                    Top--;
            }
            else
            {
                Thread.Sleep(200);
                while (Top != y)
                    Top++;
            }
        }

        public void swapMoveUP(int x, int y)
        {
            Thread.Sleep(300);
            if (Top > y)
            {
                Thread.Sleep(200);
                while (Top != y)
                    Top--;
            }
            else
            {
                Thread.Sleep(200);
                while (Top != y)
                    Top++;
            }

            if (Left > x)
            {
                Thread.Sleep(200);
                while (Left != x)
                    Left--;
            }
            else
            {
                Thread.Sleep(200);
                while (Left != x)
                    Left++;
            }
        }
    }
}
