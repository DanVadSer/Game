using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Game
{
    public partial class Form1 : Form
    {
        public BotLog bot;
        public WinDrawRestart wdr;
        public Form1()
        {
            InitializeComponent();
            bot = new BotLog();
            wdr = new WinDrawRestart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sender.GetType().GetProperty("Text").SetValue(sender, "X");
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            bot.CalculateProbabilities(ref button10, ref button11, ref button12);
            wdr.Win(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
            wdr.Draw(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
            bot.Bot(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
            bot.Bothod(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
            wdr.Win(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
            wdr.Draw(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
            bot.CalculateProbabilities(ref button10, ref button11, ref button12);
        }
    }
}
