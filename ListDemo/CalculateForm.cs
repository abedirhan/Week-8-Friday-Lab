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
    public partial class CalculateForm : Form
    { // class properties
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExits { get; set; }
        public Label ActiveLabel { get; set; }


        public CalculateForm()
        {
            InitializeComponent();

        }
        private void CalculateForm_Load(object sender, EventArgs e)
        {
            ClearNumericKeyboard();


            ActiveLabel = null;
            NumericKeyboardPanel.Visible = false;
            Size = new Size(320, 480);

        }
        /// <summary>
        /// this is the eventhandler for the calculatorForm click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Click(object sender, EventArgs e)
        {

            ClearNumericKeyboard();
            if (ActiveLabel != null)
            {
                ActiveLabel.BackColor = Color.White;
            }
            NumericKeyboardPanel.Visible = false;
            ActiveLabel = null;
        }

        /// <summary>
        /// This is the Shared event Handler for all the Calcultor Buttons' Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorNumber_Click(object sender, EventArgs e)
        {

            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;
            bool numericResult = int.TryParse(tag, out numericValue);
            if (numericResult)
            {
                int maxSize = (decimalExits) ? 5 : 3;
                if (outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if (outputString.Length < maxSize)
                    {
                        outputString += tag;
                    }

                }

                lblResult.Text = outputString;



            }
            else
            {
                switch (tag)
                {
                    case "back":
                        removeLastCharacterFromResultLabel();
                        break;
                    case "done":
                        finalizeOuput();

                        break;
                    case "clear":
                        ClearNumericKeyboard();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;

                }
            }



        }

        private void addDecimalToResultLabel()
        {
            if (!decimalExits)
            {
                outputString += ".";
                decimalExits = true;
            }
        }

        private void finalizeOuput()
        {
            outputValue = float.Parse(outputString);

            outputValue = (float)(Math.Round(outputValue, 1));

            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }

            ActiveLabel.Text = outputValue.ToString();
            ClearNumericKeyboard();

            NumericKeyboardPanel.Visible = false;
            ActiveLabel.BackColor = Color.White;
            ActiveLabel = null;
        }

        private void removeLastCharacterFromResultLabel()
        {
            var lastCharacter = outputString.Substring(outputString.Length - 1);
            if (lastCharacter == ".")
            {
                decimalExits = false;
            }

            outputString = outputString.Remove(outputString.Length - 1);

            if (outputString.Length == 0)
            {
                outputString = "0";
            }
            lblResult.Text = outputString;
        }

        private void ClearNumericKeyboard()
        {
            lblResult.Text = "0";
            outputString = "0";
            outputValue = 0.0f;
            decimalExits = false;


        }


        /// <summary>
        /// This is the event handler for the heightlabel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            if (ActiveLabel != null)
            {
                ActiveLabel.BackColor = Color.White;
                ActiveLabel = null;
            }
            ActiveLabel = sender as Label;
            ActiveLabel.BackColor = Color.LightBlue;
            NumericKeyboardPanel.Visible = true;
            if (ActiveLabel.Text != "0")
            {
                lblResult.Text = ActiveLabel.Text;
                outputString = ActiveLabel.Text;
            }
            NumericKeyboardPanel.Location = new Point(12, ActiveLabel.Location.Y + 40);
            NumericKeyboardPanel.BringToFront();
            AnimationTimer.Enabled = true;
        }
        /// <summary>
        /// This is event handler for the Animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            var currentLocation = NumericKeyboardPanel.Location;
            currentLocation = new Point(currentLocation.X, currentLocation.Y - 20);
            NumericKeyboardPanel.Location = new Point();

            if (currentLocation.Y <= ActiveLabel.Location.Y + 45)
            {
                NumericKeyboardPanel.Location = new Point(currentLocation.X, ActiveLabel.Location.Y + 45);
                AnimationTimer.Enabled = false;
            }

        }
    }
}
