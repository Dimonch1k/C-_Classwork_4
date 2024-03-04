namespace WForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox_1.Text.Length > 0 &&
                textBox_2.Text.Length > 0 &&
                textBox_sign.Text.Length > 0)

                sumbit_btn.Enabled = true;
            else
                sumbit_btn.Enabled = false;
        }



        // Submit BTN
        private void submit_btn_Click(object sender, EventArgs e)
        {
            string alph = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            if (!textBox_1.Text.Contains(alph) && !textBox_2.Text.Contains(alph))
            {
                int num1 = Int32.Parse(textBox_1.Text);
                int num2 = Int32.Parse(textBox_2.Text);
                char c = Char.Parse(textBox_sign.Text);

                if (c == '+')
                    result_label.Text = (num1 + num2).ToString();
                else if (c == '-')
                    result_label.Text = (num1 - num2).ToString();
                else if (c == '*')
                    result_label.Text = (num1 * num2).ToString();
                else if (c == '/')
                    result_label.Text = (num1 / num2).ToString();
                else
                    result_label.Text = "Error";
            }
            else
                result_label.Text = "Error!!! There is letters!!!";
        }



        private void radio_btn_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
            {
                textBox_1.Enabled = true;
                textBox_2.Enabled = false;

                radio_btn_2.Checked = false;
            }
        }

        private void radio_btn_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_2.Checked)
            {
                textBox_1.Enabled = false;
                textBox_2.Enabled = true;

                radio_btn_1.Checked = false;
            }
        }



        // 111
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '1';
            else
                textBox_2.Text += '1';
        }

        // 222
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '2';
            else
                textBox_2.Text += '2';
        }

        // 333
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '3';
            else
                textBox_2.Text += '3';
        }

        // 444
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '4';
            else
                textBox_2.Text += '4';
        }

        // 555
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '5';
            else
                textBox_2.Text += '5';
        }

        // 666
        private void btn_6_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '6';
            else
                textBox_2.Text += '6';
        }

        // 777
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '7';
            else
                textBox_2.Text += '7';
        }

        // 888
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '8';
            else
                textBox_2.Text += '8';
        }

        // 999
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '9';
            else
                textBox_2.Text += '9';
        }

        // 000
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (radio_btn_1.Checked)
                textBox_1.Text += '0';
            else
                textBox_2.Text += '0';
        }

        // +++++
        private void plus_btn_Click(object sender, EventArgs e)
        {
            textBox_sign.Text = "+";
        }

        // -----
        private void minus_btn_Click(object sender, EventArgs e)
        {
            textBox_sign.Text = "-";
        }

        // *****
        private void multi_btn_Click(object sender, EventArgs e)
        {
            textBox_sign.Text = "*";
        }

        // ////
        private void divide_btn_Click(object sender, EventArgs e)
        {
            textBox_sign.Text = "/";
        }


    }
}
