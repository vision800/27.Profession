using System.Security.Cryptography.X509Certificates;

namespace _27.Profession
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;



            string profession = "";

            if (name.Length == 0 && profession.Length == 0)
            {
                MessageBox.Show("Name or Profession must not be empty");
            }
            else
            {




                //checking profession
                if (comboBox1.Text == "Teacher")
                {
                    profession = "Teacher";
                }
                else if (comboBox1.Text == "Engineer")
                {
                    profession = "Engineer";
                }
                else if (comboBox1.Text == "Lecture")
                {
                    profession = "Lecture";
                }
                else if (comboBox1.Text == "Nurse")
                {
                    profession = "Nurse";
                }
                else
                {
                    MessageBox.Show("You did not choose profession");

                }

                // print the results
                lblDisplay.Text = $"Hi {name}, you are {GetGender()} and your profession is {profession}";
                MessageBox.Show($"Hi {name}, you are {GetGender()} and your profession is {profession}");
            }

            string GetGender()
            {
                if (rdMale.Checked)
                {
                    return "Male";
                }
                else if (rdMale.Checked)
                {
                    return "Female";
                }
                else if (rdOther.Checked)
                {
                    return "Other";
                }
                else { return ""; }
            }

            /*
             *  void GetGender()
            {
                if (rdMale.Checked)
                {
                    gender = "Male";
                }
                else if (rdMale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Other";
                }
            }
             */

        }
    }
}