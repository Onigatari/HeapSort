using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort.UserPanel
{
    public partial class WebPanel : UserControl
    {
        public WebPanel()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://neerc.ifmo.ru/wiki/index.php?title=Сортировка_кучей");
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://neerc.ifmo.ru/wiki/index.php?title=Сортировка_кучей");
        }
    }
}
