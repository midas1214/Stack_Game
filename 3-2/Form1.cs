using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_2
{
    public partial class Form1 : Form
    {
        Game g;
        public int mode, change;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            stack1_textbox.Text = "1 1 2";
            stack2_textbox.Text = "2 2";
            stack3_textbox.Text = "";
            stack4_textbox.Text = "3 3 3 1";
            stack1_text.Visible = false;
            stack2_text.Visible = false;
            stack3_text.Visible = false;
            stack4_text.Visible = false;
            selectStack1_button.Visible = false;
            selectStack2_button.Visible = false;
            selectStack3_button.Visible = false;
            selectStack4_button.Visible = false;
            status_text.Visible = false;
            backToMenu_button.Visible = false;
        }

        private void startGame_button_Click(object sender, EventArgs e)
        {
            string[] input = new string[] {stack1_textbox.Text, stack2_textbox.Text, stack3_textbox.Text, stack4_textbox.Text};
            int temp1 = 0, temp2 = 0, temp3 = 0;
            for (int i = 0; i < 4; i++)
            {
                if (input[i] == "")
                {
                    continue;
                }
                string[] splits = input[i].Split(' ');
                if (splits.Count() > 4)
                {
                    label1.Text = "測資錯誤";
                    return;
                }
                foreach (var split in splits)
                {
                    if (split == "1")
                    {
                        temp1++;
                    }
                    else if (split == "2")
                    {
                        temp2++;
                    }
                    else if (split == "3")
                    {
                        temp3++;
                    }
                    else
                    {
                        label1.Text = "測資錯誤";
                        return;
                    }
                }
            }
            if (temp1 != 3 || temp2 != 3 || temp3 != 3)
            {
                label1.Text = "測資錯誤";
                return;
            }
            mode = 1;
            g = new Game(input);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            stack1_textbox.Visible = false;
            stack2_textbox.Visible = false;
            stack3_textbox.Visible = false;
            stack4_textbox.Visible = false;
            startGame_button.Visible = false;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            stack1_text.Visible = true;
            stack2_text.Visible = true;
            stack3_text.Visible = true;
            stack4_text.Visible = true;
            stack1_text.Text = "";
            stack2_text.Text = "";
            stack3_text.Text = "";
            stack4_text.Text = "";
            selectStack1_button.Visible = true;
            selectStack2_button.Visible = true;
            selectStack3_button.Visible = true;
            selectStack4_button.Visible = true;
            selectStack1_button.Text = "選取";
            selectStack2_button.Text = "選取";
            selectStack3_button.Text = "選取";
            selectStack4_button.Text = "選取";
            status_text.Visible = true;
            status_text.Text = "...";
            backToMenu_button.Visible = true;
            stack1_text.Text = g.output(0);
            stack2_text.Text = g.output(1);
            stack3_text.Text = g.output(2);
            stack4_text.Text = g.output(3);
            if (g.cantake(0))
            {
                selectStack1_button.Enabled = true;
            }
            else
            {
                selectStack1_button.Enabled = false;
            }
            if (g.cantake(1))
            {
                selectStack2_button.Enabled = true;
            }
            else
            {
                selectStack2_button.Enabled = false;
            }
            if (g.cantake(2))
            {
                selectStack3_button.Enabled = true;
            }
            else
            {
                selectStack3_button.Enabled = false;
            }
            if (g.cantake(3))
            {
                selectStack4_button.Enabled = true;
            }
            else
            {
                selectStack4_button.Enabled = false;
            }

            if (g.win())
            {
                selectStack1_button.Text = "贏";
                selectStack2_button.Text = "贏";
                selectStack3_button.Text = "贏";
                selectStack4_button.Text = "贏";
                selectStack1_button.Enabled = false;
                selectStack2_button.Enabled = false;
                selectStack3_button.Enabled = false;
                selectStack4_button.Enabled = false;
                status_text.Text = "你贏了";
            }
        }

        private void selectStack1_button_Click(object sender, EventArgs e)
        {
            if (mode % 2 == 1) //選取
            {
                change = 0;
                status_text.Text = "你選了堆疊1";
                selectStack1_button.Text = "放置";
                selectStack2_button.Text = "放置";
                selectStack3_button.Text = "放置";
                selectStack4_button.Text = "放置";
                if (g.canplace(0) || change == 0)
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.canplace(1))
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.canplace(2))
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.canplace(3))
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            else //放置
            {
                status_text.Text = "...";
                selectStack1_button.Text = "選取";
                selectStack2_button.Text = "選取";
                selectStack3_button.Text = "選取";
                selectStack4_button.Text = "選取";
                g.move(change, 0);
                if (g.cantake(0))
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.cantake(1))
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.cantake(2))
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.cantake(3))
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            mode++;
            stack1_text.Text = g.output(0);
            stack2_text.Text = g.output(1);
            stack3_text.Text = g.output(2);
            stack4_text.Text = g.output(3);

            if (g.win())
            {
                selectStack1_button.Text = "贏";
                selectStack2_button.Text = "贏";
                selectStack3_button.Text = "贏";
                selectStack4_button.Text = "贏";
                selectStack1_button.Enabled = false;
                selectStack2_button.Enabled = false;
                selectStack3_button.Enabled = false;
                selectStack4_button.Enabled = false;
                status_text.Text = "你贏了";
            }
        }

        private void selectStack2_button_Click(object sender, EventArgs e)
        {
            if (mode % 2 == 1) //選取
            {
                change = 1;
                status_text.Text = "你選了堆疊2";
                selectStack1_button.Text = "放置";
                selectStack2_button.Text = "放置";
                selectStack3_button.Text = "放置";
                selectStack4_button.Text = "放置";
                if (g.canplace(0) || change == 0)
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.canplace(1) || change == 1)
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.canplace(2))
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.canplace(3))
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            else //放置
            {
                status_text.Text = "...";
                selectStack1_button.Text = "選取";
                selectStack2_button.Text = "選取";
                selectStack3_button.Text = "選取";
                selectStack4_button.Text = "選取";
                g.move(change, 1);
                if (g.cantake(0))
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.cantake(1))
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.cantake(2))
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.cantake(3))
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            mode++;
            stack1_text.Text = g.output(0);
            stack2_text.Text = g.output(1);
            stack3_text.Text = g.output(2);
            stack4_text.Text = g.output(3);

            if (g.win())
            {
                selectStack1_button.Text = "贏";
                selectStack2_button.Text = "贏";
                selectStack3_button.Text = "贏";
                selectStack4_button.Text = "贏";
                selectStack1_button.Enabled = false;
                selectStack2_button.Enabled = false;
                selectStack3_button.Enabled = false;
                selectStack4_button.Enabled = false;
                status_text.Text = "你贏了";
            }
        }

        private void selectStack3_button_Click(object sender, EventArgs e)
        {

            if (mode % 2 == 1) //選取
            {
                change = 2;
                status_text.Text = "你選了堆疊3";
                selectStack1_button.Text = "放置";
                selectStack2_button.Text = "放置";
                selectStack3_button.Text = "放置";
                selectStack4_button.Text = "放置";
                if (g.canplace(0))
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.canplace(1))
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.canplace(2) || change == 2)
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.canplace(3))
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            else //放置
            {
                status_text.Text = "...";
                selectStack1_button.Text = "選取";
                selectStack2_button.Text = "選取";
                selectStack3_button.Text = "選取";
                selectStack4_button.Text = "選取";
                g.move(change, 2);
                if (g.cantake(0))
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.cantake(1))
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.cantake(2))
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.cantake(3))
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            mode++;
            stack1_text.Text = g.output(0);
            stack2_text.Text = g.output(1);
            stack3_text.Text = g.output(2);
            stack4_text.Text = g.output(3);

            if (g.win())
            {
                selectStack1_button.Text = "贏";
                selectStack2_button.Text = "贏";
                selectStack3_button.Text = "贏";
                selectStack4_button.Text = "贏";
                selectStack1_button.Enabled = false;
                selectStack2_button.Enabled = false;
                selectStack3_button.Enabled = false;
                selectStack4_button.Enabled = false;
                status_text.Text = "你贏了";
            }
        }

        private void selectStack4_button_Click(object sender, EventArgs e)
        {
            if (mode % 2 == 1) //選取
            {
                change = 3;
                status_text.Text = "你選了堆疊4";
                selectStack1_button.Text = "放置";
                selectStack2_button.Text = "放置";
                selectStack3_button.Text = "放置";
                selectStack4_button.Text = "放置";
                if (g.canplace(0))
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.canplace(1))
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.canplace(2))
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.canplace(3) || change == 3)
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            else //放置
            {
                status_text.Text = "...";
                selectStack1_button.Text = "選取";
                selectStack2_button.Text = "選取";
                selectStack3_button.Text = "選取";
                selectStack4_button.Text = "選取";
                g.move(change, 3);
                if (g.cantake(0))
                {
                    selectStack1_button.Enabled = true;
                }
                else
                {
                    selectStack1_button.Enabled = false;
                }
                if (g.cantake(1))
                {
                    selectStack2_button.Enabled = true;
                }
                else
                {
                    selectStack2_button.Enabled = false;
                }
                if (g.cantake(2))
                {
                    selectStack3_button.Enabled = true;
                }
                else
                {
                    selectStack3_button.Enabled = false;
                }
                if (g.cantake(3))
                {
                    selectStack4_button.Enabled = true;
                }
                else
                {
                    selectStack4_button.Enabled = false;
                }
            }
            mode++;
            stack1_text.Text = g.output(0);
            stack2_text.Text = g.output(1);
            stack3_text.Text = g.output(2);
            stack4_text.Text = g.output(3);

            if (g.win())
            {
                selectStack1_button.Text = "贏";
                selectStack2_button.Text = "贏";
                selectStack3_button.Text = "贏";
                selectStack4_button.Text = "贏";
                selectStack1_button.Enabled = false;
                selectStack2_button.Enabled = false;
                selectStack3_button.Enabled = false;
                selectStack4_button.Enabled = false;
                status_text.Text = "你贏了";
            }
        }

        private void backToMenu_button_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "請輸入測資";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            stack1_textbox.Visible = true;
            stack2_textbox.Visible = true;
            stack3_textbox.Visible = true;
            stack4_textbox.Visible = true;
            stack1_textbox.Text = "1 1 2";
            stack2_textbox.Text = "2 2";
            stack3_textbox.Text = "";
            stack4_textbox.Text = "3 3 3 1";
            startGame_button.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            stack1_text.Visible = false;
            stack2_text.Visible = false;
            stack3_text.Visible = false;
            stack4_text.Visible = false;
            selectStack1_button.Visible = false;
            selectStack2_button.Visible = false;
            selectStack3_button.Visible = false;
            selectStack4_button.Visible = false;
            status_text.Visible = false;
            backToMenu_button.Visible = false;
        }
    }
}
