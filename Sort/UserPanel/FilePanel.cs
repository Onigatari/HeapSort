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
using System.IO;

namespace Sort.UserPanel
{
    public partial class FilePanel : UserControl
    {
        public static SortedDictionary<int, int> Graf = new SortedDictionary<int, int>();
        public static int Num;
        public static string algoTime;
        bool FirstClicl = false;

        public FilePanel()
        {
            InitializeComponent();
            FuncAlgo.Series[1].Points.Clear();
            GrafDict();
            PaintGraf();
            for(int n = 1; n <= 1000; n++)
                FuncAlgo.Series[0].Points.AddXY(n, n * Math.Log(n, 2));
        }

        public void GrafDict()
        {
            StreamReader sr = new StreamReader("grafPoint.txt");
            int n = int.Parse(sr.ReadLine());
            Num = n;
            for (int i = 0; i < n; i++)
            {
                string[] temp = sr.ReadLine().Split();
                string temp_Index = temp[0];
                string temp_Num = temp[1];

                if (!Graf.ContainsKey(int.Parse(temp_Index)))
                    Graf.Add(int.Parse(temp_Index), (int.Parse(temp_Num)));
                else
                    Graf[int.Parse(temp_Index)] = int.Parse(temp_Num);
            }
            sr.Close();
        }

        public void PaintGraf()
        {
            FuncAlgo.Series[1].Points.Clear();
            foreach (var item in Graf)
                FuncAlgo.Series[1].Points.AddXY(item.Key, item.Value);
        }

        public void AddGraf(int index, int num)
        {
            if (!Graf.ContainsKey(index))
            {
                Graf.Add(index, num);
                Num++;
            }
            else
                Graf[index] = num;
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            NewMasTextBox.Clear();
            Stopwatch time = new Stopwatch();
            long[] array = HeapSort.Sort.arrayReadText(MainMasTextBox.Text);
            time.Start();
            HeapSort.Sort.heapSort(ref array);
            time.Stop();
            string temp = HeapSort.Sort.outputArray(ref array);
            algoTime = time.Elapsed.Ticks.ToString();
            int n = HeapSort.Count.size;
            NewMasTextBox.Text += "================================\n";
            NewMasTextBox.Text += "Теоретическое время работы: " + Math.Ceiling(n * Math.Log(n, 2)) + "\n";
            NewMasTextBox.Text += "Практическое время работы: " + algoTime + "\n";
            NewMasTextBox.Text += "Кол-во элементов: " + n + "\n";
            NewMasTextBox.Text += "================================\n";
            NewMasTextBox.Text += temp;
            NewMasTextBox.Text += '\n';
            TimerSec.SelectionAlignment = HorizontalAlignment.Center;
            TimerSec.Text = algoTime;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "(Текстовый файл: )|*.txt";

            if (OFD.ShowDialog() == DialogResult.OK)
                MainMasTextBox.Text = File.ReadAllText(OFD.FileName);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.FileName = "Unnamed.txt";
            SFD.Filter = "(Текстовый файл: )|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
                File.WriteAllText(SFD.FileName, NewMasTextBox.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MainMasTextBox.Clear();
            NewMasTextBox.Clear();
            TimerSec.Clear();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            NewMasTextBox.Clear();
            TimerSec.Clear();
            Random rnd = new Random();
            int n = rnd.Next(1, 1000);
            string line = null;
            for (int i = 0; i < n - 1; i++)
            {
                line += rnd.Next(-100000, 100000);
                if (i % 8 == 0 && i != 0)
                    line += '\n';
                else
                    line += " ";
            }
            line += rnd.Next(-10000, 10000);
            MainMasTextBox.Text = line;
        }

        private void AddBottun_Click(object sender, EventArgs e)
        {
            if (FirstClicl)
            {
                AddGraf(HeapSort.Count.size, int.Parse(algoTime));
                PaintGraf();
            }
            else
            {
                Clear_Click(sender, e);
                FirstClicl = true;
            }
        }
    }
}
