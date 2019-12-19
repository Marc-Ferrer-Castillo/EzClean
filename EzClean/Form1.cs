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

        // Drive letter 
        const string DRIVERLETTER = "c:";

        //  import Shell32.dll
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        
        // user folder
        string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString();

        // Directories that can be cleared
        List<DirectoryInfo> totalDirectories = new List<DirectoryInfo>();       

        // Directories that will be cleared
        List<bool> directoriesToClear = new List<bool>();

        

        // Constructor
        public EzClean()
        {
            InitializeComponent();

            // Fills directories with paths
            fillDirectories();

            // Fills the list with true values as many as existing paths
            bool clear = true;
            for (int i = 0; i < totalDirectories.Count() + 1; i++)
            {
                directoriesToClear.Add(clear);
            } 
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

            //Changes label text
            labelDir.Text = "";
            // Changes button image
            this.BackgroundImage = Properties.Resources.buttonUnpressed;
        }
        
        private void clean()
        {
            try
            {        
                // Cleans Recycle Bin
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);

                // For each dir in dirs list
                foreach (DirectoryInfo item in totalDirectories)
                {
                    // Empties it
                    try
                    {
                        labelDir.Text = item.ToString();
                        emptyDir(item);
                    }
                    catch (Exception){}
                    
                }                
            }

            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show(ex.Message, "Error while cleaning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }           
        }

        private void emptyDir(DirectoryInfo dir)
        {     
            foreach (FileInfo file in dir.GetFiles())
            {
                // Deletes file
                try{file.Delete();}
                catch (Exception){}
            }
            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                // Delete directory
                try{directory.Delete(true);}
                catch (Exception){}                    
            }                        
        }

        // Close program
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(directoriesToClear);

            settings.ShowDialog();
        }

        private void fillDirectories()
        {
            // Directories to be cleared
            DirectoryInfo dir   = new DirectoryInfo(userFolder   + "\\temp");
            DirectoryInfo dir2  = new DirectoryInfo(DRIVERLETTER + "\\temp");
            DirectoryInfo dir3  = new DirectoryInfo(DRIVERLETTER + "\\Windows\\SoftwareDistribution");
            DirectoryInfo dir4  = new DirectoryInfo(userFolder   + "\\AppData\\Local\\Microsoft\\Windows\\Temporary Internet Files");
            DirectoryInfo dir5  = new DirectoryInfo(userFolder   + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache");
            DirectoryInfo dir6  = new DirectoryInfo(DRIVERLETTER + "\\Windows.old");
            DirectoryInfo dir7  = new DirectoryInfo(DRIVERLETTER + "\\Windows\\LiveKernelReports");
            DirectoryInfo dir8  = new DirectoryInfo(DRIVERLETTER + "\\Windows\\Prefetch");
            DirectoryInfo dir9  = new DirectoryInfo(DRIVERLETTER + "\\ProgramData\\Microsoft\\Windows\\WER");
            DirectoryInfo dir10 = new DirectoryInfo(DRIVERLETTER + "\\Windows\\Minidump");

            // Adding dirs to dirsToClear list   
            totalDirectories.Add(dir);
            totalDirectories.Add(dir2);
            totalDirectories.Add(dir3);
            totalDirectories.Add(dir4);
            totalDirectories.Add(dir5);
            totalDirectories.Add(dir6);
            totalDirectories.Add(dir7);
            totalDirectories.Add(dir8);
            totalDirectories.Add(dir9);
            totalDirectories.Add(dir10);
        }
    }
}
