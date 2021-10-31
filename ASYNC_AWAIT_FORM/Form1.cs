using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASYNC_AWAIT_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static async void Cook()
        {
            var ret = await HeatUP();
            Console.WriteLine("RET is -> " + ret);
            CookEggs();
            CookBecons();
            Console.WriteLine("Cook() End");
        }

        public static async void CookEggs()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Egges cooked");
            });
            Console.WriteLine("CookEggs() End");
        }

        public static async void CookBecons()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Becons cooked");
            });
            Console.WriteLine("CookBecons() End");
        }

        public static async Task<bool> HeatUP()
        {
            bool result = false;
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Heat Up complete");
                result = true;
            });
            Console.WriteLine("HeatUP() End");
            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Cook();
        }
    }
}
