using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operatorClicked = "";
        private bool isOperatorClicked = false;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void click_btn(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || (isOperatorClicked)) 
                resultBox.Clear();
            isOperatorClicked = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!resultBox.Text.Contains("."))
                    resultBox.Text = resultBox.Text + btn.Text;
            }
            else
                resultBox.Text = resultBox.Text + btn.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operatorClicked = btn.Text;
            isOperatorClicked = true;
            resultValue = Double.Parse(resultBox.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultValue = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
               case "+":
                   resultBox.Text = (resultValue + Double.Parse(resultBox.Text)).ToString();
                   break;
               case "-":
                   resultBox.Text = (resultValue - Double.Parse(resultBox.Text)).ToString();
                   break;
               case "X":
                   resultBox.Text = (resultValue * Double.Parse(resultBox.Text)).ToString();
                   break;
               case "/":
                   resultBox.Text = (resultValue / Double.Parse(resultBox.Text)).ToString();
                   break;
            }
        }
    }
}