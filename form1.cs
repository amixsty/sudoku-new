using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{   
    
    public partial class Form1 : Form
    {
        TextBox[,] myinput;
        public Form1()
        {
            InitializeComponent();
            myinput = new TextBox[9, 9];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox myinput = new TextBox();
                    myinput.TextAlign = HorizontalAlignment.Center;
                    myinput.Font = new Font("Tahoma", 25);
                    myinput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    tableLayoutPanel1.Controls.Add(myinput, i, j);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            if (x.ShowDialog() == DialogResult.OK)
            {
                string file_path = x.FileName;
                StreamReader my_file_reader = new StreamReader(file_path);
                string big_text = my_file_reader.ReadToEnd();
                MessageBox.Show(big_text);
                char[] my_file_seprator = { ' ', '\n'};
                string[] numbers = big_text.Split(my_file_seprator);
            }
        }
    }
}
