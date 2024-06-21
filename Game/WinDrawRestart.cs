using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class WinDrawRestart
    {
        public void Win(ref Button button1, ref Button button2, ref Button button3, ref Button button4, ref Button button5, ref Button button6, ref Button button7, ref Button button8, ref Button button9)
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                if (button1.Text != "")
                {
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
            if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    if (button4.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
            if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                if (button7.Text != "")
                {
                    if (button7.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
            if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                if (button1.Text != "")
                {
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
            if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                if (button2.Text != "")
                {
                    if (button2.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
            if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                if (button3.Text != "")
                {
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
            if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                if (button1.Text != "")
                {
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
            if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                if (button3.Text != "")
                {
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("YOU LOSE!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                    else
                    {
                        MessageBox.Show("YOU WIN!");
                        Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
                    }
                }
            }
        }
        public void Draw(ref Button button1, ref Button button2, ref Button button3, ref Button button4, ref Button button5, ref Button button6, ref Button button7, ref Button button8, ref Button button9)
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != ""
                && button4.Text != "" && button5.Text != "" && button6.Text != ""
                && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Draw!");
                Restart(ref button1, ref button2, ref button3, ref button4, ref button5, ref button6, ref button7, ref button8, ref button9);
            }
        }

        public void Restart(ref Button button1, ref Button button2, ref Button button3, ref Button button4, ref Button button5, ref Button button6, ref Button button7, ref Button button8, ref Button button9)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}