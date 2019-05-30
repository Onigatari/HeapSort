using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    class MoveButton:Button
    {
        Timer timer = new Timer();
        int tick = 10;
        int currentTick = 0;
        double dX, dY;

        private void timerTick(object sender, EventArgs e)
        {
            currentTick++;
            if (currentTick >= tick) timer.Enabled = false;
            Left += Convert.ToInt32(dX);
            Top += Convert.ToInt32(dY);
        }

        public MoveButton() : base()
        {
            timer.Tick += timerTick;
            Width = 60;
            Height = 60;
        }

        public MoveButton(int x, int y) : this()
        {
            Left = x;
            Top = y;
        }

        public void start(int x, int y)
        {
            dX = x / tick;
            dY = y / tick;
            timer.Enabled = true;
        }
    }
}
