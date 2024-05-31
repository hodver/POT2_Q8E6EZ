using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POT2_Q8E6EZ
{
    public partial class FormNew : Form
    {   
        public KavezoAdat NewKA=new KavezoAdat();
        public FormNew()
        {
            InitializeComponent();
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            kavezoAdatBindingSource.DataSource = NewKA;
        }
    }
}
