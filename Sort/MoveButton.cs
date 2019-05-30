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
        double tick = 10;
        double currentTick = 0;
        double dif_x, dif_y;

        private void timerTick(object sender, EventArgs e)
        {
            currentTick++;
            if (currentTick > tick) timer.Enabled = false;
            Left += Convert.ToInt32(dif_x);
            Top += Convert.ToInt32(dif_y);
        }

        public MoveButton() : base()
        {
            Width = 60;
            Height = 60;
            timer.Tick += timerTick;
        }

        public MoveButton(int x, int y) : this()
        {
            Top = y;
            Left = x;
        }

        public void start(int x, int y)
        {
            dif_x = x / tick;
            dif_y = y / tick;
            timer.Enabled = true;
            Left = Convert.ToInt32(dif_x);
            Top = Convert.ToInt32(dif_y);
        }
    }
}
