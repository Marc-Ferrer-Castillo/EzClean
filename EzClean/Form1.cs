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
    public partial class EzClean : Form
    {
       

        // Constantes needed to move the window
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //  import Shell32.dll
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        
       
        // total Space cleared
        long freedSpace = 0;
        // Drive letter 
        string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);
        // user folder
        string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString();

        
        // Constructor
        public EzClean()
        {
            InitializeComponent();
        }

        enum RecycleFlags : uint
        {
            SHRB_NOCONFIRMATION = 0x00000001, // Don't ask confirmation
            SHRB_NOPROGRESSUI = 0x00000002, // Don't show any windows dialog
            SHRB_NOSOUND = 0x00000004 // Don't make sound
        }


        



        // Allows moving window
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        // Load event
        private void EzClean_Load(object sender, EventArgs e)
        {

        }

        // Clean click
        private void btnClean_Click(object sender, EventArgs e)
        {
            // Changes button image
            this.BackgroundImage = Properties.Resources.MainScreen;

            // Cleaning function
            clean();

            // Shows the space cleared into the label
            btnResult.Text = freedSpace + " bytes cleared.";

            // Changes button image
            this.BackgroundImage = Properties.Resources.buttonUnpressed;
        }
        
        private void clean()
        {
            try
            {
                // Cleans Recycle Bin
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                               
                
                var dir = new DirectoryInfo ( userFolder + "\\temp");
                var dir2 = new DirectoryInfo( userFolder + "\\AppData\\Local\\Temp" );

                dir.Delete(true);
                dir2.Delete(true);

            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show(ex.Message, "Error while cleaning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            
        }
    }
}
