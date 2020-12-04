using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandBook_2020
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string fileName)
        {
            InitializeComponent();
            
            this.axAcroPDF1.LoadFile(fileName);


        }

     
    }
}
