using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzClean
{
    public partial class Settings : Form
    {
        // Constantes needed to move the window
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        // ON = The item that corresponds to the list will be cleared
        public const bool ON = true;
        public const bool OFF = false;


        // Directories to clear
        List<bool> directoriesToClear;
        
        // Constructor
        public Settings(List<bool> dirsToClear)
        {            
            InitializeComponent();
            this.directoriesToClear = dirsToClear;
            for (int i = 0; i < directoriesToClear.Count(); i++)
            {
                checkedListBoxDirectoriesToClear.SetItemChecked(i, directoriesToClear[i]);
            }            
        }




        // Allows moving window
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }        

        // Close program click
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
        // Close click
        private void pictureBoxCloseSettings_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }

        // When an item is checked
        private void checkedListBoxDirectoriesToClear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the element is checked, marks the position on directoriesToClear as True
            if (checkedListBoxDirectoriesToClear.GetItemChecked(checkedListBoxDirectoriesToClear.SelectedIndex))            
                directoriesToClear[checkedListBoxDirectoriesToClear.SelectedIndex] = true;
            
            else            
                directoriesToClear[checkedListBoxDirectoriesToClear.SelectedIndex] = false;            
        }
    }
}
