using System.Globalization;
using System.Net.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//BRUNA  SILVA 301295779 
namespace Assignment_GUI
{
    public partial class Bruna : Form
    {
     
        decimal val1 = 0;
        decimal val2 = 0;
        string operation = "";
        string username = ""; 
        static int count = 0;

        public Bruna()
        {
            InitializeComponent();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioScientific.Checked)
            {
                    btnPi.Visible = true;
                    btnPower.Visible = true;
                    btnFactorial.Visible = true;
                    btnroot.Visible = true;
            }
            else
            {
                    btnPi.Visible = false;
                    btnPower.Visible = false;
                    btnFactorial.Visible = false;
                    btnroot.Visible = false;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDarkMode.Checked)
            {
                tabCalculator.BackColor = Color.DarkGray;
                tapAboutMe.BackColor= Color.DarkGray;
                result.BackColor = Color.Wheat;
                btn01.BackColor = Color.DarkKhaki;
                btn02.BackColor = Color.DarkKhaki;
                btn03.BackColor = Color.DarkKhaki;
                btn04.BackColor = Color.DarkKhaki;
                btn05.BackColor = Color.DarkKhaki;
                btn06.BackColor = Color.DarkKhaki;
                btn07.BackColor = Color.DarkKhaki;
                btn08.BackColor = Color.DarkKhaki;
                btn09.BackColor = Color.DarkKhaki;
                btn0.BackColor = Color.DarkKhaki;
                btndot.BackColor = Color.DarkKhaki; 
                btnplusless.BackColor = Color.DarkKhaki;
            }
            else
            {
                tabCalculator.BackColor = Color.Gainsboro;
                tapAboutMe.BackColor = Color.Gainsboro;
                result.BackColor = Color.LemonChiffon;
                btn01.BackColor = Color.Black;
                btn02.BackColor = Color.Black;
                btn03.BackColor = Color.Black;
                btn04.BackColor = Color.Black;
                btn05.BackColor = Color.Black;
                btn06.BackColor = Color.Black;
                btn07.BackColor = Color.Black;
                btn08.BackColor = Color.Black;
                btn09.BackColor = Color.Black;
                btn0.BackColor = Color.Black;
                btndot.BackColor = Color.Black;
                btnplusless.BackColor = Color.Black;
            }
        }
        private void Bruna_Load(object sender, EventArgs e)
        {

        }
        private void radioStand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStand.Checked)
            {
                btnPi.Visible = false;
                btnPower.Visible = false;
                btnFactorial.Visible = false;
                btnroot.Visible = false;
              
            }
            else
            {
                btnPi.Visible = true;
                btnPower.Visible = true;
                btnFactorial.Visible = true;
                btnroot.Visible = true;
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0"; 
        }
        private void result_Click(object sender, EventArgs e)
        {

            if (operation == "+")
            {
                val2 = Convert.ToDecimal(result.Text);
                result.Text = Convert.ToString(val1 + val2); }

            else if (operation == "-")
            {
                val2 = Convert.ToDecimal(result.Text);
                result.Text = Convert.ToString(val1 - val2); }

            else if (operation == "*")
            {
                val2 = Convert.ToDecimal(result.Text); 
                result.Text = Convert.ToString(val1 * val2); }

            else if (operation == "/")
            {
                val2 = Convert.ToDecimal(result.Text);
                if (val2 == 0)
                {
                    result.Text = "Error";
                }
                else
                {
                    result.Text = Convert.ToString(val1 / val2);
                }
            }
            else if (operation == "^")
            {
                val2 = Convert.ToDecimal(result.Text); 
                result.Text = Convert.ToString(val1 * val1); }

            else if (operation == "x^y")
            {
                val2 = Convert.ToDecimal(result.Text); 
                result.Text = Convert.ToString((decimal)Math.Pow((double)val1, (double)val2)); }

            else if (operation == "sine")
            {
                decimal ResSine = (val1 * (decimal)Math.PI) / 180;
                result.Text = Convert.ToString((decimal)Math.Sin((double)ResSine));
            }
            else if (operation == "corsine")
            {
                decimal ResCor = (val1 * (decimal)Math.PI) / 180;
                result.Text = Convert.ToString((decimal)Math.Cos((double)ResCor));
            }
            else if (operation == "!")
            { if (val1 == 0 || val1 == 1)
                {
                    result.Text = "1";
                }
                else if (val1 < 0)
                {
                    result.Text = "Error";
                }
                else
                {
                    int fac = 1;
                    while (val1 != 1)
                    {
                        result.Text = Convert.ToString(fac = (int)val1 * fac);
                        val1--;
                    }
                }
            }
            else if (operation == "root")
            {
                result.Text = Convert.ToString((decimal)Math.Sqrt((double)val1));
            }

            else
            {  result.Text = "Error";}
        }
        private void btn01_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }
        private void btn02_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }
        private void btn03_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }
        private void btn04_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ".";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text ="";
        }
       private void btnsum_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "+";
        }

        private void btnsubt_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "-";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "/";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + Math.PI;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "x^y";
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "!";
        }
        private void btnsine_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "root";

        }
        private void tbnLog_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "corsine";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            username = Convert.ToString(Usernamee.Text);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            count++; 
            MessageBox.Show($"Hello {username}, \r\n\r\nMy name is Bruna Fernanda and I am a SOFTWARE ENGINEERING TECHNICIAN student at Centennial and I'm in my second term.\r\nThis is my calculator project, I hope you liked it.\r\n Thank you for use it {username}.\r\n Enjoy.\r\n\r\n Number of views: {count}");
        }
        private void btnroot_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text = "";
            operation = "sine";
        }
        private void btnplusless_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDecimal(result.Text);
            result.Text= Convert.ToString(val1 * (-1));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
