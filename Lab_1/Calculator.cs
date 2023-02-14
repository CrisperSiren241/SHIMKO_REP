namespace Lab_1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(RadioButton radio in groupBox1.Controls)
            {
                radio.Checked = false;  
            }
            foreach (RadioButton radio in groupBox2.Controls)
            {
                radio.Checked = false;
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Checkmethod();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR!");
            }

        }

        private void Checkmethod()
        {
            int Value;

            Value = Convert.ToInt32(textBox1.Text);

            //Если в первом групбоксе помечена "Россия"

            if (radioButton1.Checked && radioButton8.Checked)
            {
                textBox2.Text = textBox1.Text;
            }
            else if (radioButton1.Checked && radioButton7.Checked)
            {
                textBox2.Text = Convert.ToString(Value - 34);
            }
            else if (radioButton1.Checked && radioButton6.Checked)
            {
                textBox2.Text = Convert.ToString(Value - 6);
            }
            else if (radioButton1.Checked && radioButton5.Checked)
            {
                textBox2.Text = Convert.ToString(Value - 32);
            }

            //Если в первом групбоксе помечена "Европа"

            if (radioButton2.Checked && radioButton8.Checked)
            {
                textBox2.Text = Convert.ToString(Value + 6);
            }
            else if (radioButton2.Checked && radioButton7.Checked)
            {
                textBox2.Text = textBox1.Text;
            }
            else if (radioButton2.Checked && radioButton6.Checked)
            {
                textBox2.Text = Convert.ToString(Value - 28);
            }
            else if (radioButton2.Checked && radioButton5.Checked)
            {
                textBox2.Text = Convert.ToString(Value - 26);
            }

            //Если в первом групбоксе помечена "США"

            if (radioButton3.Checked && radioButton8.Checked)
            {
                textBox2.Text = Convert.ToString(Value + 34);
            }
            else if (radioButton3.Checked && radioButton7.Checked)
            {
                textBox2.Text = Convert.ToString(Value + 28);
            }
            else if (radioButton3.Checked && radioButton6.Checked)
            {
                textBox2.Text = textBox1.Text;
            }
            else if (radioButton3.Checked && radioButton5.Checked)
            {
                textBox2.Text = Convert.ToString(Value + 2);
            }

            //Если в первом групбоксе помечена "Британия"

            if (radioButton4.Checked && radioButton8.Checked)
            {
                textBox2.Text = Convert.ToString(Value + 32);
            }
            else if (radioButton4.Checked && radioButton7.Checked)
            {
                textBox2.Text = Convert.ToString(Value + 26);
            }
            else if (radioButton4.Checked && radioButton6.Checked)
            {
                textBox2.Text = Convert.ToString(Value - 2);
            }
            else if (radioButton4.Checked && radioButton5.Checked)
            {
                textBox2.Text = textBox1.Text;
            }

            if (Value % 2 != 0)
            {
                MessageBox.Show("Неверно введены данные!");
                textBox2.Text = "";
            }
        }
    }
}