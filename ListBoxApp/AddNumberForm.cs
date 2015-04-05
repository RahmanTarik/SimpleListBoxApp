using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxApp
{
    public partial class AddNumberToListBox : Form
    {
        public AddNumberToListBox()
        {
            InitializeComponent();
        }

        private int number;
        private void addButton_Click(object sender, EventArgs e)
        {
            numberListBox.Items.Clear();
            number = Convert.ToInt32(numberTextBox.Text);
            for (int i = 0; i <= number; i++)
            {
                numberListBox.Items.Add(i);
                numberTextBox.Text = "";
            }

        }
        
        private void showButton_Click(object sender, EventArgs e)
        {
            if (numberListBox.SelectedItem != null)
            {
                MessageBox.Show("You have selected: " + numberListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("You have selected nothing");
            }
        }

        private void numberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (numberListBox.SelectedItem != null)
            //{
            //    MessageBox.Show("you have selected: " + numberListBox.SelectedItem);
            //}
            //else
            //{
            //    MessageBox.Show("you have selected nothing");
            //}
        }
    }
}
