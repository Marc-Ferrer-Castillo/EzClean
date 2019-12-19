using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzClean
{
    public partial class Settings : Form
    {
        // Constructor
        public Settings(List<DirectoryInfo> dirsToClear)
        {
            
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {            
            // Close program
            this.Close();
        }
    }
}
