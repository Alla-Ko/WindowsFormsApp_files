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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_del.Enabled= false;
            listBox1.SelectionMode = SelectionMode.One;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            Form2 form= new Form2();
            form.Show();
            form.FormClosed += (sender1, e1) =>
            {
                // Цей код виконається після закриття форми
                if (form.my_filename.Length > 0)
                    listBox1.Items.Add(form.my_filename);
                    
            };
        }
        private void button_del_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedItems.Count == 0) button_del.Enabled = false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
                button_del.Enabled = true;
        }
    }
}
