using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_files
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public string my_filename="";
        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Виберіть файл";
            string my_filters = "";
            if (comboBox1.SelectedIndex != 0)
            {
                
                my_filters += comboBox1.SelectedItem?.ToString();
                my_filters += "|";
            }
            my_filters += "Всі файли(*.*) | *.*";
           
            dialog.Filter = my_filters;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            my_filename = dialog.FileName;
            this.Close();
        }
    }
}
