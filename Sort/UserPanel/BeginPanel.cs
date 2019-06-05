using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sort.UserPanel
{
    public partial class BeginPanel : UserControl
    {
        bool FirstClick = true;

        public BeginPanel()
        {
            InitializeComponent();
            TimerSec.SelectionAlignment = HorizontalAlignment.Center;
            CountArray.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            FirstClick = false;
            Stopwatch time = new Stopwatch();
            long[] array = HeapSort.Sort.arrayReadText(MasReadTextBox.Text);
            time.Start();
            HeapSort.Sort.heapSort(ref array);
            time.Stop();
            MasWriteTextBox.Text = null;
            MasWriteTextBox.Text = HeapSort.Sort.outputMainArray(ref array);
            CountArray.Text = HeapSort.Count.size.ToString();
            TimerSec.SelectionAlignment = HorizontalAlignment.Center;
            TimerSec.Text = time.ElapsedTicks.ToString();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            FirstClick = false;
            Random rnd = new Random();
            int n = rnd.Next(1, 30);
            string line = null;
            for (int i = 0; i < n - 1; i++)
            {
                line += rnd.Next(-1000, 1000);
                if (i % 10 == 0 && i != 0)
                    line += '\n';
                else
                    line += " ";
            }
            line += rnd.Next(-10000, 10000);
            MasReadTextBox.Text = line;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstClick = true;
            MasReadTextBox.Text = null;
            MasReadTextBox.Text = "Введите изначальную последовательность...";
            MasWriteTextBox.Text = null;
            TimerSec.Text = null;
            CountArray.Text = null;
        }

        private void MasReadTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (FirstClick)
                MasReadTextBox.Text = null;
            FirstClick = false;
        }
    }
}
