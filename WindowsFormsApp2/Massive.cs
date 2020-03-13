using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Massive : Form
    {
        public GetMass Mass;
        public Massive()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        
        private void Massive_Load(object sender, EventArgs e)
        {
            foreach (var item in Mass.MassiveOne())
            {
              
                listBox1.Items.Add(item.ToString());
            }
            foreach (var item in Mass.MassiveTwo())
            {
                listBox2.Items.Add(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        var result = int.Parse(listBox1.Items[i].ToString()) + int.Parse(listBox2.Items[i].ToString());
                        listBox3.Items.Add(result);
                    }
                    break;
                case 1:
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        var result = int.Parse(listBox1.Items[i].ToString()) - int.Parse(listBox2.Items[i].ToString());
                        listBox3.Items.Add(result);
                    }
                    break;
            }
           
        }
    }
}
