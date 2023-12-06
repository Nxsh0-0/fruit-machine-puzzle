using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_machine__puzzle
{
    public partial class Form1 : Form
    {
        static Image apple = fruit_machine__puzzle.Properties.Resources.apple;
        static Image banana = fruit_machine__puzzle.Properties.Resources.banana;
        static Image cherry = fruit_machine__puzzle.Properties.Resources.cherry;
         static Image orange = fruit_machine__puzzle.Properties.Resources.orange;
        static Image peach = fruit_machine__puzzle.Properties.Resources.peach;      
        static Image strawb = fruit_machine__puzzle.Properties.Resources.strawberry;
        static Image appleB = fruit_machine__puzzle.Properties.Resources.appleB;
        static Image bananaB = fruit_machine__puzzle.Properties.Resources.bananaB;
        static Image cherryB = fruit_machine__puzzle.Properties.Resources.cherryB;
        static Image orangeB = fruit_machine__puzzle.Properties.Resources.orangeB;
        static Image peachB = fruit_machine__puzzle.Properties.Resources.peachB;
        static Image strawbB = fruit_machine__puzzle.Properties.Resources.strawberryB;
        static Image appleT = fruit_machine__puzzle.Properties.Resources.appleT;
        static Image bananaT = fruit_machine__puzzle.Properties.Resources.bananaT;
        static Image cherryT = fruit_machine__puzzle.Properties.Resources.cherryT;
        static Image orangeT = fruit_machine__puzzle.Properties.Resources.orangeT;
        static Image peachT = fruit_machine__puzzle.Properties.Resources.peachT;
        static Image strawbT = fruit_machine__puzzle.Properties.Resources.strawberryT;
        static Image[] items = {apple,banana, cherry, orange, peach,strawb};
        static Image[] itemsB = { appleB, bananaB, cherryB, orangeB, peachB, strawbB };
        static Image[] itemsT = { appleT, bananaT, cherryT, orangeT, peachT, strawbT };
        static bool spin = false;
        static Random rnd = new Random();
        static int picpointer1 = rnd.Next(6);
        static int picpointer2 = rnd.Next(6);  //check in case of fail
        static int picpointer3 = rnd.Next(6);
        static Image slot1hold;
        static Image slot2hold;
        static Image slot3hold;
        static int money = 100;
        static bool hold1 = false;
        static bool hold2 = false;
        static bool hold3 = false;
        public Form1()
        {
            InitializeComponent();
            moneybox.Text = "";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            money = money - 10;
            if (money < 0)
            {
                moneybox.Text = "You do not have enough money to spin :(";
                spin = false;
            }
            else
            {
                moneybox.Text = "You have £" + money.ToString();
                if (spin == true) { spin = false; }
                else { spin = true; }

                if (spin)
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                }
                spin = false;
                Start.BackColor = Color.Green;
                hold1 = false; hold2 = false; hold3 = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picpointer1++;
            slot1.BackgroundImage = items[picpointer1%items.Length];
            slot1B.BackgroundImage = itemsB[(picpointer1+1) % items.Length];
            slot1T.BackgroundImage = itemsT[(picpointer1 - 1) % items.Length];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picpointer2++;
            slot2.BackgroundImage = items[picpointer2 % items.Length];
            slot2B.BackgroundImage = itemsB[(picpointer2 + 1) % items.Length];
            slot2T.BackgroundImage = itemsT[(picpointer2 - 1) % items.Length];
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            picpointer3++;
            slot3.BackgroundImage = items[picpointer3 % items.Length];
            slot3B.BackgroundImage = itemsB[(picpointer3 + 1) % items.Length];
            slot3T.BackgroundImage = itemsT[(picpointer3 - 1) % items.Length];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            slot1hold = slot1.BackgroundImage;
            hold1 = true;
            if (hold1 && hold2 && hold3)
            {
                if (slot1.BackgroundImage == slot2.BackgroundImage && slot1.BackgroundImage == slot3.BackgroundImage)
                {
                    money = money + 500;
                    moneybox.Text = "YOU WON THE JACKPOT!! YOU EARNED £500";
                }
                if (slot1.BackgroundImage == slot2.BackgroundImage ||
                     slot1.BackgroundImage == slot3.BackgroundImage ||
                     slot2.BackgroundImage == slot3.BackgroundImage)
                {
                    moneybox.Text = "You earned a mini prize of £50!";
                    money = money + 50;
                }
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            slot2hold = slot2.BackgroundImage;
            hold2= true;
            if (hold1 && hold2 && hold3)
            {
                if (slot1.BackgroundImage == slot2.BackgroundImage && slot1.BackgroundImage == slot3.BackgroundImage)
                {
                    money = money + 500;
                    moneybox.Text = "YOU WON THE JACKPOT!! YOU EARNED £500";
                }
                if (slot1.BackgroundImage == slot2.BackgroundImage ||
                     slot1.BackgroundImage == slot3.BackgroundImage ||
                     slot2.BackgroundImage == slot3.BackgroundImage)
                {
                    moneybox.Text = "You earned a mini prize of £50!";
                    money = money + 50;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            slot3hold = slot3.BackgroundImage;
            hold3= true;
            if (hold1 && hold2 && hold3)
            {
                if (slot1.BackgroundImage == slot2.BackgroundImage && slot1.BackgroundImage == slot3.BackgroundImage)
                {
                    money = money + 500;
                    moneybox.Text = "YOU WON THE JACKPOT!! YOU EARNED £500";
                }
                if (slot1.BackgroundImage == slot2.BackgroundImage ||
                     slot1.BackgroundImage == slot3.BackgroundImage ||
                     slot2.BackgroundImage == slot3.BackgroundImage)
                {
                    moneybox.Text = "You earned a mini prize of £50!";
                    money = money + 50;
                }
                
            }
        }

        private void slot2B_Click(object sender, EventArgs e)
        {

        }

        private void slot1B_Click(object sender, EventArgs e)
        {

        }

        private void nudge1_Click(object sender, EventArgs e)
        {
            if(hold1)
            {
                money = money - 20;
                slot1.BackgroundImage = items[(picpointer1 + 1)% items.Length];
                slot1B.BackgroundImage = itemsB[(picpointer1 + 2) % items.Length];
                slot1T.BackgroundImage = itemsT[(picpointer1) % items.Length];
            }
            if (slot1.BackgroundImage == slot2.BackgroundImage && slot1.BackgroundImage == slot3.BackgroundImage)
            {
                money = money + 500;
                moneybox.Text = "YOU WON THE JACKPOT!! YOU EARNED £500";
            }
            if(slot1.BackgroundImage == slot2.BackgroundImage ||
                 slot1.BackgroundImage == slot3.BackgroundImage||
                 slot2.BackgroundImage == slot3.BackgroundImage)
            {
                moneybox.Text = "You earned a mini prize of £50!";
                money = money + 50;
            }
        }

        private void nudge2_Click(object sender, EventArgs e)
        {
            if (hold2)
            {
                money = money - 20;
                slot2.BackgroundImage = items[(picpointer2 + 1) % items.Length];
                slot2B.BackgroundImage = itemsB[(picpointer2 + 2) % items.Length];
                slot2T.BackgroundImage = itemsT[(picpointer2) % items.Length];
            }
            if (slot1.BackgroundImage == slot2.BackgroundImage && slot1.BackgroundImage == slot3.BackgroundImage)
            {
                money = money + 500;
                moneybox.Text = "YOU WON THE JACKPOT!! YOU EARNED £500";
            }
            if (slot1.BackgroundImage == slot2.BackgroundImage ||
                 slot1.BackgroundImage == slot3.BackgroundImage ||
                 slot2.BackgroundImage == slot3.BackgroundImage)
            {
                moneybox.Text = "You earned a mini prize of £50!";
                money = money + 50;
            }
        }

        private void nudge3_Click(object sender, EventArgs e)
        {
           if (hold3)
            {
                money = money - 20;
                slot3.BackgroundImage = items[(picpointer3 + 1) % items.Length];
                slot3B.BackgroundImage = itemsB[(picpointer3 + 2) % items.Length];
                slot3T.BackgroundImage = itemsT[(picpointer3) % items.Length];
            }
            if (slot1.BackgroundImage == slot2.BackgroundImage && slot1.BackgroundImage == slot3.BackgroundImage)
            {
                money = money + 500;
                moneybox.Text = "YOU WON THE JACKPOT!! YOU EARNED £500";
            }
            if (slot1.BackgroundImage == slot2.BackgroundImage ||
                 slot1.BackgroundImage == slot3.BackgroundImage ||
                 slot2.BackgroundImage == slot3.BackgroundImage)
            {
                moneybox.Text = "You earned a mini prize of £50!";
                money = money + 50;
            }
        }
        
    }
}
