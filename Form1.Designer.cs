namespace Form_Convertor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblpath2 = new System.Windows.Forms.Label();
            this.btnhoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnconvert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsavepath = new System.Windows.Forms.Button();
            this.lblsavepath = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstfiles = new System.Windows.Forms.ListBox();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose path contain bal files :\r\n";
            // 
            // lblpath2
            // 
            this.lblpath2.AutoSize = true;
            this.lblpath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblpath2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblpath2.Location = new System.Drawing.Point(21, 38);
            this.lblpath2.Name = "lblpath2";
            this.lblpath2.Size = new System.Drawing.Size(182, 13);
            this.lblpath2.TabIndex = 1;
            this.lblpath2.Text = "bal files is layout file for basic4android";
            // 
            // btnhoose
            // 
            this.btnhoose.Location = new System.Drawing.Point(306, 18);
            this.btnhoose.Name = "btnhoose";
            this.btnhoose.Size = new System.Drawing.Size(100, 33);
            this.btnhoose.TabIndex = 2;
            this.btnhoose.Text = "Choose path";
            this.btnhoose.UseVisualStyleBackColor = true;
            this.btnhoose.Click += new System.EventHandler(this.btnhoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "_______________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exist bal files in path :";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblpath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblpath.Location = new System.Drawing.Point(129, 149);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(10, 13);
            this.lblpath.TabIndex = 6;
            this.lblpath.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(21, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "_______________________________________________________________";
            // 
            // btnconvert
            // 
            this.btnconvert.Enabled = false;
            this.btnconvert.Location = new System.Drawing.Point(306, 518);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(100, 33);
            this.btnconvert.TabIndex = 8;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(21, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Web : www.iranapp.org";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(284, 583);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "E-mail: info@iranapp.org";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(21, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Press delete key on item for remove it from list";
            // 
            // btnsavepath
            // 
            this.btnsavepath.Location = new System.Drawing.Point(306, 76);
            this.btnsavepath.Name = "btnsavepath";
            this.btnsavepath.Size = new System.Drawing.Size(100, 33);
            this.btnsavepath.TabIndex = 14;
            this.btnsavepath.Text = "Choose path";
            this.btnsavepath.UseVisualStyleBackColor = true;
            this.btnsavepath.Click += new System.EventHandler(this.btnsavepath_Click);
            // 
            // lblsavepath
            // 
            this.lblsavepath.AutoSize = true;
            this.lblsavepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsavepath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblsavepath.Location = new System.Drawing.Point(21, 97);
            this.lblsavepath.Name = "lblsavepath";
            this.lblsavepath.Size = new System.Drawing.Size(76, 13);
            this.lblsavepath.TabIndex = 13;
            this.lblsavepath.Text = "No define path";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Choose path to save bil files (converted from bal to bil)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "1)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(3, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "2)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(3, 527);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "3)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(21, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(385, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "_______________________________________________________________";
            // 
            // lstfiles
            // 
            this.lstfiles.Location = new System.Drawing.Point(19, 204);
            this.lstfiles.Name = "lstfiles";
            this.lstfiles.Size = new System.Drawing.Size(387, 264);
            this.lstfiles.TabIndex = 19;
            this.lstfiles.UseTabStops = false;
            this.lstfiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstfiles_DrawItem);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(29, 519);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(271, 32);
            this.pb1.TabIndex = 20;
            this.pb1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 603);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lstfiles);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnsavepath);
            this.Controls.Add(this.lblsavepath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnhoose);
            this.Controls.Add(this.lblpath2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpath2;
        private System.Windows.Forms.Button btnhoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsavepath;
        private System.Windows.Forms.Label lblsavepath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstfiles;
        private System.Windows.Forms.ProgressBar pb1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

