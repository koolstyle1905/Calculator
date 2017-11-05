using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double temp1 = 0, temp2 = 0, temp3 = 0;
        bool input = true;
        String sign = "";

        public Form1()
        {
            InitializeComponent();
            radDegree.Checked = true;
            txtResult.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            sign = string.Empty;
            txtResult.Text = "";
        }

        private void parseNum()
        {
            temp1 = double.Parse(txtResult.Text);
            txtResult.Text = string.Empty;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                parseNum();
                sign = "+";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(txtResult.Text == "")
            {
                txtResult.Text += "-";
            }
            else
            {
                parseNum();
                sign = "-";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                parseNum();
                sign = "*";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                parseNum();
                sign = "/";
            }
        }

        private void displayResult()
        {
            string Result = temp1.ToString();
            if (Result.Contains('.') || Result.Contains("."))
            { txtResult.Text = string.Format("{0:0.##########}", temp1); }
            else
            { txtResult.Text = string.Format("{0:0.##########}", temp1); }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                temp2 = double.Parse(txtResult.Text);
                switch (sign)
                {
                    case "+": temp3 = temp1 += temp2; displayResult(); break;
                    case "-": temp3 = temp1 -= temp2; displayResult(); break;
                    case "*": temp3 = temp1 *= temp2; displayResult(); break;
                    case "/":
                        if (temp2 != 0)
                        {
                            temp3 = temp1 /= temp2;
                            displayResult();
                        }
                        else
                        {
                            MessageBox.Show("Can't divide by 0");
                        }
                        break;
                    case "%":
                        if (temp2 != 0)
                        {
                            temp3 = temp1 %= temp2;
                            displayResult();
                        }
                        else
                        {
                            MessageBox.Show("Can't mod by 0");
                        }
                        break;
                    case "^": temp3 = temp1 = Math.Pow(temp1, temp2); displayResult(); break;
                    case "y√x":
                        if (temp1 != 0)
                        {
                            temp3 = Math.Pow(temp1, 1.0 / temp2);
                            txtResult.Text = temp3.ToString();
                        }
                        else
                        {
                            txtResult.Text = "Math Error";
                        }
                        input = false;
                        break;
                      
                }
                input = false;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length == 0)
            {
                return;
            }
            else
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.StartsWith("-"))
            {
                txtResult.Text = txtResult.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(txtResult.Text) && decimal.Parse(txtResult.Text) != 0)
            {
                txtResult.Text = "-" + txtResult.Text;
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                temp1 = Convert.ToDouble(txtResult.Text);
                int factorial = 1;
                for (int i = 1; i <= temp1; i++)
                {
                    temp3 = factorial *= i;
                }
                txtResult.Text = factorial.ToString();
                input = false;
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            temp3 = temp1 = Math.PI;
            displayResult();
            input = false;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                parseNum();
                sign = "%";
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            temp1 = 0;
            temp2 = 0;
            temp3 = 0;
            sign = string.Empty;
            txtResult.Text = "";
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            txtResult.Text = temp3.ToString();
            input = false;
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            var button = (DevExpress.XtraEditors.SimpleButton)sender;

            switch (button.Text)
            {
                case "0":
                    if (input == true)
                    {
                        txtResult.Text += "0";
                    }
                    else
                    {
                        txtResult.Text = "0";
                        input = true;
                    }
                    break;
                case "1":
                    if (input == true)
                    {
                        txtResult.Text += "1";
                    }
                    else
                    {
                        txtResult.Text = "1";
                        input = true;
                    }
                    break;
                case "2":
                    if (input == true)
                    {
                        txtResult.Text += "2";
                    }
                    else
                    {
                        txtResult.Text = "2";
                        input = true;
                    }
                    break;
                case "3":
                    if (input == true)
                    {
                        txtResult.Text += "3";
                    }
                    else
                    {
                        txtResult.Text = "3";
                        input = true;
                    }
                    break;
                case "4":
                    if (input == true)
                    {
                        txtResult.Text += "4";
                    }
                    else
                    {
                        txtResult.Text = "4";
                        input = true;
                    }
                    break;
                case "5":
                    if (input == true)
                    {
                        txtResult.Text += "5";
                    }
                    else
                    {
                        txtResult.Text = "5";
                        input = true;
                    }
                    break;
                case "6":
                    if (input == true)
                    {
                        txtResult.Text += "6";
                    }
                    else
                    {
                        txtResult.Text = "6";
                        input = true;
                    }
                    break;
                case "7":
                    if (input == true)
                    {
                        txtResult.Text += "7";
                    }
                    else
                    {
                        txtResult.Text = "7";
                        input = true;
                    }
                    break;
                case "8":
                    if (input == true)
                    {
                        txtResult.Text += "8";
                    }
                    else
                    {
                        txtResult.Text = "8";
                        input = true;
                    }
                    break;
                case "9":
                    if (input == true)
                    {
                        txtResult.Text += "9";
                    }
                    else
                    {
                        txtResult.Text = "9";
                        input = true;
                    }
                    break;
                case ".":
                    if (!(txtResult.Text.Contains('.') || txtResult.Text.Contains('.')))
                    {
                        txtResult.Text += ".";
                    }
                    break;
                case "Inverse":
                    btnInverse.Text = "Inverse Active";
                    btnSqrt.Text = "1/x";
                    btnXPow2.Text = "x^3";
                    btnXPowY.Text = "y√x";
                    btn10PowX.Text = "e^x";
                    btnLog.Text = "ln";
                    if (btnHyperbolic.Text == "Hyperbolic")
                    {
                        btnCos.Text = "Cos-1";
                        btnSin.Text = "Sin-1";
                        btnTan.Text = "Tan-1";
                    }
                    else
                    {
                        btnCos.Text = "Cosh-1";
                        btnSin.Text = "Sinh-1";
                        btnTan.Text = "Tanh-1";
                    }
                    break;
                case "Inverse Active":
                    btnInverse.Text = "Inverse";
                    btnSqrt.Text = "√";
                    btnXPow2.Text = "x^2";
                    btnXPowY.Text = "x^y";
                    btn10PowX.Text = "10^x";
                    btnLog.Text = "log";
                    if (btnHyperbolic.Text == "Hyperbolic")
                    {
                        btnCos.Text = "Cos";
                        btnSin.Text = "Sin";
                        btnTan.Text = "Tan";
                    }
                    else
                    {
                        btnCos.Text = "Cosh";
                        btnSin.Text = "Sinh";
                        btnTan.Text = "Tanh";
                    }
                    break;
                case "Hyperbolic":
                    btnHyperbolic.Text = "Hyperbolic Active";
                    if (btnInverse.Text == "Inverse")
                    {
                        btnCos.Text = "Cosh";
                        btnSin.Text = "Sinh";
                        btnTan.Text = "Tanh";
                    }
                    else
                    {
                        btnCos.Text = "Cosh-1";
                        btnSin.Text = "Sinh-1";
                        btnTan.Text = "Tanh-1";
                    }
                    break;
                case "Hyperbolic Active":
                    btnHyperbolic.Text = "Hyperbolic";
                    if (btnInverse.Text == "Inverse")
                    {
                        btnCos.Text = "Cos";
                        btnSin.Text = "Sin";
                        btnTan.Text = "Tan";
                    }
                    else
                    {
                        btnCos.Text = "Cos-1";
                        btnSin.Text = "Sin-1";
                        btnTan.Text = "Tan-1";
                    }
                    break;
                default:
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void calculatorInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This calculator is property of \n Tran Le Anh Minh \n To Quoc Bao", "About calculator");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double temp4;
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                if (radDegree.Checked == true)
                {
                    if (btnCos.Text == "Cos")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Cos(temp4);
                        txtResult.Text = temp3.ToString();

                    }
                    else if (btnCos.Text == "Cos-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Acos(temp4);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnCos.Text == "Cosh")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Cosh(temp4);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnCos.Text == "Cosh-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Log(temp4 + Math.Sqrt(Math.Pow(temp4, 2) - 1));
                        txtResult.Text = temp3.ToString();
                    }
                }
                else if (radRadian.Checked == true)
                {
                    if (btnCos.Text == "Cos")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Cos(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnCos.Text == "Cos-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Acos(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnCos.Text == "Cosh")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Cosh(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnCos.Text == "Cosh-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Log(temp1 + Math.Sqrt(Math.Pow(temp1, 2) - 1));
                        txtResult.Text = temp3.ToString();
                    }
                }
                input = false;
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double temp4;
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                if (radDegree.Checked == true)
                {
                    if (btnTan.Text == "Tan")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Tan(temp4);
                        txtResult.Text = temp3.ToString();

                    }
                    else if (btnTan.Text == "Tan-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Atan(temp4);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnTan.Text == "Tanh")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Tanh(temp4);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnTan.Text == "Tanh-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = 0.5 * Math.Log((1 + temp4) / (1 - temp4));
                        txtResult.Text = temp3.ToString();
                    }
                }
                else if (radRadian.Checked == true)
                {
                    if (btnTan.Text == "Tan")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Tan(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnTan.Text == "Tan-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Atan(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnTan.Text == "Tanh")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Tanh(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnTan.Text == "Tanh-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = 0.5 * Math.Log((1 + temp1) / (1 - temp1));
                        txtResult.Text = temp3.ToString();
                    }
                }
                input = false;
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double temp4;
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                if (radDegree.Checked == true)
                {
                    if (btnSin.Text == "Sin")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Sin(temp4);
                        txtResult.Text = temp3.ToString();

                    }
                    else if (btnSin.Text == "Sin-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Asin(temp4);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnSin.Text == "Sinh")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Sinh(temp4);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnSin.Text == "Sinh-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp4 = RadianToDegree(temp1);
                        temp3 = Math.Log(temp4 + Math.Sqrt(Math.Pow(temp4, 2) + 1));
                        txtResult.Text = temp3.ToString();
                    }
                }
                else if (radRadian.Checked == true)
                {
                    if (btnSin.Text == "Sin")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Sin(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnSin.Text == "Sin-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Asin(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnSin.Text == "Sinh")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Sinh(temp1);
                        txtResult.Text = temp3.ToString();
                    }
                    else if (btnSin.Text == "Sinh-1")
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Log(temp1 + Math.Sqrt(Math.Pow(temp1, 2) + 1));
                        txtResult.Text = temp3.ToString();
                    }
                }
                input = false;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(btnLog.Text == "log")
            {
                double log;
                if (txtResult.Text != string.Empty)
                {
                    temp1 = Convert.ToDouble(txtResult.Text);
                    temp3 = log = Math.Log10(temp1);
                    txtResult.Text = log.ToString();
                    input = false;
                }
                else
                {
                    MessageBox.Show("Please input number first", "Error");
                    input = false;
                }
                input = false;
            }
            else
            {
                double ln;
                if (txtResult.Text != string.Empty)
                {
                    temp1 = Convert.ToDouble(txtResult.Text);
                    temp3 = ln = Math.Log(temp1);
                    txtResult.Text = ln.ToString();
                    input = false;
                }
                else
                {
                    MessageBox.Show("Please input number first", "Error");
                    input = false;
                }
            }
        }

        private void btnXPowY_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                if (btnXPowY.Text == "x^y")
                {
                    parseNum();
                    sign = "^";
                }
                else
                {
                    parseNum();
                    sign = "y√x";
                }
            }
        }

        private void btn10PowX_Click(object sender, EventArgs e)
        {
            if(btn10PowX.Text == "10^x")
            {
                if (string.IsNullOrEmpty(txtResult.Text))
                {
                    MessageBox.Show("Please input number first", "Error");
                    input = false;
                }
                else if (double.TryParse(txtResult.Text.Trim(), out temp1))
                {
                    double pow;
                    temp3 = pow = Math.Pow(10, temp1);
                    txtResult.Text = pow.ToString();
                    input = false;
                }
                else
                {
                    txtResult.Text = "Math Error";
                    input = false;
                }
            }
            else
            {
                try
                {
                    if (txtResult.Text != string.Empty)
                    {
                        temp1 = Convert.ToDouble(txtResult.Text);
                        temp3 = Math.Exp(temp1);
                        txtResult.Text = temp3.ToString();
                        input = false;
                    }
                    if (txtResult.Text == string.Empty)
                    {
                        temp3 = temp1 = Math.Exp(1);
                        displayResult();
                        input = false;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if(txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                if (btnSqrt.Text == "√")
                {
                    temp1 = Convert.ToDouble(txtResult.Text);
                    temp3 = temp1 = Math.Sqrt(temp1);
                    txtResult.Text = temp3.ToString();
                    input = false;
                }
                else
                {
                    temp1 = Convert.ToDouble(txtResult.Text);
                    temp3 = 1 / temp1;
                    txtResult.Text = temp3.ToString();
                    input = false;
                }
            }
            
        }

        private void btnXPow2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                MessageBox.Show("Please input number first", "Error");
            }
            else
            {
                if (btnSqrt.Text == "x^2")
                {
                    temp1 = Convert.ToDouble(txtResult.Text);
                    temp3 = temp1 = Math.Pow(temp1,2);
                    txtResult.Text = temp3.ToString();
                    input = false;
                }
                else
                {
                    temp1 = Convert.ToDouble(txtResult.Text);
                    temp3 = temp1 = Math.Pow(temp1, 3);
                    txtResult.Text = temp3.ToString();
                    input = false;
                }
            }
            
        }

        private double DegreeToRadian(double angle)
        {
            return angle * (Math.PI / 180.0);
        }

        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }


    }
}
