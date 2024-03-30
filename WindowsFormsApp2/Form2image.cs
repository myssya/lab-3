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
    public partial class Form2image : Form
    {
        public Form2image()
        {
            InitializeComponent();
        }

        private void Form2image_Load(object sender, EventArgs e)
        {

        }
        public int W
        {
            get
            {
                string text = tbWidth.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }
        public int H
        {
            get
            {
                string text = tbHeight.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        bool _canceled = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            _canceled = true;
            Close();
        }
        bool _close = false;
        public bool Close
        {
            get { return _canceled; }
        }

        public bool Canceled
        {
            get { return _canceled; }
        }
    }
}
