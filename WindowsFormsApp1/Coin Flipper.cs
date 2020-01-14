using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Coin_Flipper : Form
    {
        public Coin_Flipper()
        {
            InitializeComponent();
        }

        private void Coin_Flipper_Load(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            int heads = 0;
            int tails = 0;
            int result = 0;
           

            for (int i = 0; i < 10000; ++i)
            {
                result = Rand.Next(0, 2);

                if (result == 1)
                {
                    ++heads;
                }
                else
                {
                    ++tails;
                }
            }
            lblHead.Text = "Heads was flipped " + heads + " times";
            lblTail.Text = "Tails was flipped " + tails + " times";
        }

        private void lblTail_Click(object sender, EventArgs e)
        {

        }
    }
}
