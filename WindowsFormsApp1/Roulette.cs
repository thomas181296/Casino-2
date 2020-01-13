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
    public partial class Roulette : Form
    {
        public Roulette()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Answer_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int number = rng.Next(1, 36);
            int userEntry = 0;

            
            lblNumber.Text = "The random number was" + number;
           

            if(number == userEntry)
            {
                lblMoney.Text = "Congratulations, you have just won 100,000";
            }
            else
            {
                lblMoney.Text = "Your guess does not match the random number, maybe try again";
            }
        }

        private void Roulette_Load(object sender, EventArgs e)
        {

        }
    }
}
