using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDemo
{
    public partial class Lesson9Form : Form
    {
        public Lesson9Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Shared event Handler for all the Calcultor Buttons' Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorNumber_Click(object sender, EventArgs e)
        {
            Button selectedButton =sender as Button;
            //Button selectedButton = (Button) sender;
            //lblResult.Text = selectedButton.Text;
//            switch (selectedButton.Text)
//            {
//                case "1":
//                    lblResult.Text = "1";
//                    break;
//            }

            try
            {
                int.Parse(selectedButton.Text);
                lblResult.Text=selectedButton.Text;
            }
            catch
            {
                lblResult.Text = "Is not number";
            }
       
        }
    }
}
