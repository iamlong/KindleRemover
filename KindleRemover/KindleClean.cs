using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindleRemover
{
    public partial class KindleClean : Form
    {
        public KindleClean()
        {
            InitializeComponent();
        }

        Dictionary<string, DirectoryInfo> removeDirMap = new Dictionary<string,DirectoryInfo>();

        private void selectBtn_Click(object sender, EventArgs e)
        {
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderDialog.ShowNewFolderButton = false;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath.Text = folderDialog.SelectedPath;
            }
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            removeDirMap.Clear();
            messageList.Items.Clear();
            ArrayList FolderList = new ArrayList();

            DirectoryInfo dir = new DirectoryInfo(folderPath.Text);

            FileInfo[] allFiles = dir.GetFiles();
            Dictionary<String, FileInfo> FileDict = new Dictionary<string,FileInfo>();
            foreach (FileInfo file in allFiles)
            {
                if ((file.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    String filename = file.Name.Remove(file.Name.LastIndexOf("."));
                    if (filename != "")
                        FileDict.Add(filename, file);
                }
            }

            DirectoryInfo[] allDirs = dir.GetDirectories();
            foreach (DirectoryInfo subdir in allDirs)
            {
                int pos = subdir.Name.LastIndexOf(".sdr");
                String dirname;
                if (pos > 0)
                {
                    if (subdir.Name.IndexOf(@"Software Update Letter_PSNL") < 0){
                        dirname = subdir.Name.Remove(pos);
                        if (!FileDict.ContainsKey(dirname))
                        {
                            messageList.Items.Add(dirname);
                            removeDirMap.Add(dirname + ".sdr", subdir);
                        }
                    }
                }
            }
            MessageBox.Show("Scan Complete");
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            messageList.Items.Clear();
            foreach (DirectoryInfo subdir in removeDirMap.Values)
            {
                try
                {
                    subdir.Delete(true);
                }
                catch (Exception ex)
                {
                    messageList.Items.Add(ex.ToString());
                }
            }
            MessageBox.Show("Clean Complete");
        }
    }
}
