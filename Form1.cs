using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Form_Convertor
{
    public partial class Form1 : Form
    {
        string[] file_list;
        string save_path;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnhoose_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (string file in files)
                {
                    FileInfo f1 = new FileInfo(file);
                    if (f1.Extension == ".bal")
                    {
                        lstfiles.Items.Add(f1.FullName); 
                        //lstfiles.Items.Add(new MyListBoxItem(Color.Black, f1.FullName));
                    }
                }

                if (lblsavepath.Text != "") btnconvert.Enabled = true;
                lblpath2.Text = "Found " + lstfiles.Items.Count + " file in " + folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnsavepath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                lblsavepath.Text = folderBrowserDialog1.SelectedPath;
                if (lblpath.Text != "") btnconvert.Enabled = true;
            }
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            
            if (lblsavepath.Text == "" || lblpath.Text == "")
            {
                MessageBox.Show("Please choose path relevant it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstfiles.Items.Count == 0)
            {
                MessageBox.Show("There are no any bal files in choosen path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            System.Windows.Forms.ListBox.ObjectCollection d1 = lstfiles.Items;

            file_list = new string[d1.Count];

            for (int i = 0; i < d1.Count; i++)
            {
               // MyListBoxItem ob = d1[i] as MyListBoxItem;
                //file_list[i] = ob.Message;
                file_list[i] = d1[i].ToString();
            }

            Convert();

        }

        public void Convert()
        {
            pb1.Visible = true;
            timer1.Enabled = true;
            save_path = lblsavepath.Text;
            lstfiles.Items.Clear();
            backgroundWorker1.RunWorkerAsync();
        }

        private void lstfiles_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;

            MyListBoxItem item = lstfiles.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                g.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    lstfiles.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * lstfiles.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
                g.Dispose();
            }
            else
            {
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            int ExitCode;
            ProcessStartInfo ProcessInfo;
            Process process;

            try
            {
                for (int i = 0; i < file_list.Length; i++)
                {
                    string item = file_list[i].ToString();
                    FileInfo fi1 = new FileInfo(item);
                    string name = fi1.Name.Replace(".bal", ".bil");
                    ProcessInfo = new ProcessStartInfo("java", " -jar Bal2Bil.jar \"" + item + "\" \"" + lblsavepath.Text + "\\" + name + "\"");
                    ProcessInfo.CreateNoWindow = true;
                    ProcessInfo.UseShellExecute = false;
                    ProcessInfo.WorkingDirectory = Application.StartupPath;
                    // *** Redirect the output ***
                    ProcessInfo.RedirectStandardError = true;
                    ProcessInfo.RedirectStandardOutput = true;
                    process = Process.Start(ProcessInfo);
                    process.WaitForExit();
                    ExitCode = process.ExitCode;

                    string file_path = save_path + "\\" + name;
                    if (File.Exists(file_path))
                    {
                        //lstfiles.Items.Add(new MyListBoxItem(Color.Green, "Success: " + item));
                        //lstfiles.Items.Add("Success: " + item);
                        backgroundWorker1.ReportProgress(1,item);
                    }
                    else
                    {
                        //lstfiles.Items.Add(new MyListBoxItem(Color.Red, "Error: " + item));
                        //lstfiles.Items.Add("Error: " + item);
                        backgroundWorker1.ReportProgress(0, item);
                    }

                    process.Close();
                }
                
                backgroundWorker1.ReportProgress(2);

            }
            catch (Exception e1)
            {
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                lstfiles.Items.Add("Success: " + e.UserState.ToString());
                lstfiles.SelectedIndex = lstfiles.Items.Count - 1;
            }
            else if (e.ProgressPercentage == 0)
            {
                lstfiles.Items.Add("Error: " + e.UserState.ToString());
                lstfiles.SelectedIndex = lstfiles.Items.Count - 1;
            }
            else if (e.ProgressPercentage == 2)
            {
                timer1.Enabled = false;
                pb1.Visible = false;
                if (MessageBox.Show("Files convert to basic4iOS files successfully\r\nDo you want to open output directory?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    Process.Start(@lblsavepath.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb1.Value == 100) pb1.Value = 1;
            pb1.Value += 1;
        }

    }
}
