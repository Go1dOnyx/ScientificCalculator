using Antlr.Runtime.Tree;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ScientificCalculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        static double a, c, d;
        static char  b;
        static string[] operatorList = {"*","/","+","-"};

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void oneBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + oneBtn.Text;
            }
            else {
                inputBox.Text = inputBox.Text + oneBtn.Text;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + twoBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + twoBtn.Text;
            }
        }

        protected void threeBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + threeBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + threeBtn.Text;
            }
        }
                        
        //Backspace button
        protected void Button4_Click(object sender, EventArgs e)
        {
            //check how many characters it has
            int characterCount = 0;
            foreach (char letter in inputBox.Text)
            {
                characterCount++;
            }

            //Checks if input text is empty
            if (inputBox.Text == "")
            {
                inputBox.Text = "";
            }
            //If the current input contains an operator sign
            //Then make no changes to its value
            else if (operatorList.Contains(inputBox.Text)) {
                inputBox.Text = inputBox.Text;
            }
            //Uses characterCount to check if it only has one character, so 
            // it can be set to zero or empty and not get any errors.
            else if (characterCount == 1)
            {
                inputBox.Text="";
            }
            //If characterCount is more than one then user can proceed to remove 
            //the characters he had typed per each 
            else if (characterCount > 1)
            {

                char[] inputBoxArray = inputBox.Text.ToCharArray();
                char[] newInputBoxString = new char[inputBoxArray.Length-1];
                string newString = "";

                for (int index = 0; index < inputBoxArray.Length-1; index++)
                {
                    newInputBoxString[index] = inputBoxArray[index];
                }
                foreach (char letter in newInputBoxString)
                {
                    newString += letter;
                }

                inputBox.Text = newString;
            }
        }

        protected void fourBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + fourBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + fourBtn.Text;
            }
        }

        protected void fiveBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + fiveBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + fiveBtn.Text;
            }
        }

        protected void sixBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + sixBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + sixBtn.Text;
            }
        }
        //Division button
        protected void divBtn_Click(object sender, EventArgs e)
        {
                a = Convert.ToDouble(inputBox.Text);
                inputBox.Text = "";
                b = '/';
                inputBox.Text += b;
        }

        protected void sevenBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + sevenBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + sevenBtn.Text;
            }
        }

        protected void eightBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + eightBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + eightBtn.Text;
            }
        }

        protected void nineBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + nineBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + nineBtn.Text;
            }
        }

        //Multiplication button
        protected void multiBtn_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(inputBox.Text);
            inputBox.Text = "";
            b = '*';
            inputBox.Text += b;
        }

        //Positive or Negative Sign
        protected void posOrNegBtn_Click(object sender, EventArgs e)
        {
            //This is used to check if the current text is either empty
            // Or if it contains an operator, so we can make no changes
            if (inputBox.Text == "" || (operatorList.Contains(inputBox.Text)))
            {
                inputBox.Text=inputBox.Text;
            }
            //This is to check if the current character is not a operator
            else if(!operatorList.Contains(inputBox.Text)){
                //This button is to turn the current number to positive or negative
                double number = double.Parse(inputBox.Text);
                if (number < 0)
                {
                    //turn number to positive
                    number = number * -1;
                }
                else if (number > 0)
                {
                    //turn number to negative
                    number = number * -1;
                }
                inputBox.Text = number.ToString();
            }
        }

        protected void zeroBtn_Click(object sender, EventArgs e)
        {
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + zeroBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + zeroBtn.Text;
            }
        }

        protected void decimalBtn_Click(object sender, EventArgs e)
        {
            //Check for this one
            if ((inputBox.Text=="+") || (inputBox.Text=="-") || (inputBox.Text=="*") || (inputBox.Text=="/"))
            {
                inputBox.Text = "";
                inputBox.Text = inputBox.Text + decimalBtn.Text;
            }
            else
            {
                inputBox.Text = inputBox.Text + decimalBtn.Text;
            }
        }
        
        //Addition button
        protected void plusBtn_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(inputBox.Text);
            inputBox.Text = "";
            b = '+';
            inputBox.Text += b;
        }

        //Squared Operation
        protected void xSqrBtn_Click(object sender, EventArgs e)
        {
            //Square the current text value
            double currentNum;
            currentNum = Convert.ToDouble(inputBox.Text);
            currentNum = currentNum * currentNum;
            inputBox.Text = currentNum.ToString();

        }

        //Erase Button
        protected void clearBtn_Click(object sender, EventArgs e)
        {
            //Clear all variable values and text box input
            inputBox.Text="";
            a=0;
            c=0;
            d=0;
            b='\0';
            resultsText.Text = "";
        }

        //Equals Button
        protected void equalBtn_Click(object sender, EventArgs e)
        {
            resultsText.Text="";
            //If nothing has been type then make no change
            if (inputBox.Text == "") {
                inputBox.Text = inputBox.Text;
            }
            //This is used to prevent the bug where it keeps adding itself again
            //each time you click the equal sign
            if (inputBox.Text == d.ToString()) {
                inputBox.Text = inputBox.Text;
            }
            else {
                c = Convert.ToDouble(inputBox.Text);
                inputBox.Text="";
                if (b == '/')
                {
                    d = a / c;
                    inputBox.Text +=d;
                    resultsText.Text = $"{a} / {c} = {d}";
                    a = d;
                }
                else if (b == '*')
                {
                    d = a * c;
                    inputBox.Text +=d;
                    resultsText.Text = $"{a} * {c} = {d}";
                    a = d;
                }
                else if (b == '+')
                {
                    d = a + c;
                    inputBox.Text +=d;
                    resultsText.Text = $"{a} + {c} = {d}";
                    a = d;
                }
                else if (b == '-')
                {
                    d = a - c;
                    inputBox.Text +=d;
                    resultsText.Text = $"{a} - {c} = {d}";
                    a = d;
                }
            }
        }

        //Substraction button
        protected void minusBtn_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(inputBox.Text);
            inputBox.Text = "";
            b = '-';
            inputBox.Text += b;
        }

    }
}