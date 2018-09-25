using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DadRenamePicture
{
    public partial class RenamePictureMainForm : Form
    {
        public RenamePictureMainForm()
        {
            InitializeComponent();
            //G:\Programming\DadRenameAdi\Pics_Folder
            string defPicSourceFolder;
            defPicSourceFolder = System.Environment.GetEnvironmentVariable("DAD_RENAME_DEFAULT_FOLDER");

            if (defPicSourceFolder == null)
            {
                defPicSourceFolder = "C:/Users/Delu/tiulim/sud italia 2018 05 work";
            }

            txtSourceFolder.Text = defPicSourceFolder;
            txtColor.BackColor = Color.Red;
            setShowLog();

            Console.SetOut(new Logger(txtLogger));
            Console.WriteLine("Rename Picture Form Initialized...");
        }

        private void btnProcessPictures_Click(object sender, EventArgs e)
        {
            Console.WriteLine("started processing pictures...");
            string picSourceFolder = txtSourceFolder.Text;
            string picTargetFolder = (cbxAddDate.Checked?picSourceFolder + "_Date":picSourceFolder+"_turned");

            if (Directory.Exists(picTargetFolder))
            {

                Console.WriteLine("Folder {0} already exists.", picTargetFolder);
                DialogResult dr = MessageBox.Show("Folder already exists." + Environment.NewLine + " Do you want to delete it?", "Are You sure?", MessageBoxButtons.YesNo);

                if(!dr.Equals(DialogResult.Yes))
                {
                    Console.WriteLine("Folder {0} already exists, aborting at user's request.", picTargetFolder);
                    return;
                }

                Console.WriteLine("Folder {0} already exists, deleting it at user's request.", picTargetFolder);
                Directory.Delete(picTargetFolder, true);
                Console.WriteLine("Folder {0} deleted successfully.", picTargetFolder);
            }

            Console.WriteLine("Creating Folder {0}", picTargetFolder);
            Directory.CreateDirectory(picTargetFolder);

            btnProcessPictures.Enabled = false;

            DoProcessPictures xxx = new DoProcessPictures();
            backgroundWorker1.DoWork += xxx.DoProcessPictures_DoWork;
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(EndPictureProcessing);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(ProgressReport);
            int sizeBarValue = dateTimeSizeBar.Value;
            backgroundWorker1.RunWorkerAsync(new string[] { picSourceFolder, picTargetFolder, sizeBarValue.ToString(), cbxAddDate.Checked.ToString(), System.Convert.ToString(hourModifier.Value),txtColor.BackColor.Name,txtHorizontalOffset.Text, txtVerticalOffset.Text });
        }

        public void EndPictureProcessing(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            lblProgressText.Text = "Finished";
            btnProcessPictures.Enabled = true;
        }

        public void ProgressReport(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = Math.Min(e.ProgressPercentage, 100);

            lblProgressText.Text = ""+ e.ProgressPercentage + "%";
       
        }

        private void btnBrowseSourceFolder_Click(object sender, EventArgs e)
        {
            txtSourceFolder.Text = GetFolderDialogResult(txtSourceFolder.Text);
        }


        private string GetFolderDialogResult(string rootPath)
        {
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.SelectedPath = rootPath;
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            return null;
        }

        private void dateTimeSizeBar_Scroll(object sender, EventArgs e)
        {
            String sizeBarLabelTemplate = "Date Size (Height xx% of picture)";
            int sizeBarValue = ((System.Windows.Forms.TrackBar)(sender)).Value;
            lblDateSize.Text = sizeBarLabelTemplate.Replace("xx", sizeBarValue.ToString());
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtColor.BackColor = colorDialog1.Color;
            }
        }

        private void cbxShowLog_CheckedChanged(object sender, EventArgs e)
        {
            this.setShowLog();
            
        }

        private void setShowLog()
        {
            if (cbxShowLog.Checked)
            {
                this.Height = 650;
            }
            else
            {
                this.Height = 300;
            }
            appLogSplitter.Panel2Collapsed = !cbxShowLog.Checked;
        }
       
    }

}


