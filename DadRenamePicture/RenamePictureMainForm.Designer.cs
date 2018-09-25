namespace DadRenamePicture
{
  partial class RenamePictureMainForm
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
        this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        this.colorDialog1 = new System.Windows.Forms.ColorDialog();
        this.appLogSplitter = new System.Windows.Forms.SplitContainer();
        this.btnProcessPictures = new System.Windows.Forms.Button();
        this.cbxShowLog = new System.Windows.Forms.CheckBox();
        this.txtSourceFolder = new System.Windows.Forms.TextBox();
        this.btnBrowseSourceFolder = new System.Windows.Forms.Button();
        this.hourModifier = new System.Windows.Forms.NumericUpDown();
        this.txtVerticalOffset = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.lblPictureSource = new System.Windows.Forms.Label();
        this.cbxAddDate = new System.Windows.Forms.CheckBox();
        this.label3 = new System.Windows.Forms.Label();
        this.btnChooseColor = new System.Windows.Forms.Button();
        this.progressBar1 = new System.Windows.Forms.ProgressBar();
        this.lblDateSize = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.txtColor = new System.Windows.Forms.TextBox();
        this.lblProgressText = new System.Windows.Forms.Label();
        this.dateTimeSizeBar = new System.Windows.Forms.TrackBar();
        this.txtHorizontalOffset = new System.Windows.Forms.TextBox();
        this.txtLogger = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.appLogSplitter)).BeginInit();
        this.appLogSplitter.Panel1.SuspendLayout();
        this.appLogSplitter.Panel2.SuspendLayout();
        this.appLogSplitter.SuspendLayout();
        this.txtSourceFolder.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.hourModifier)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dateTimeSizeBar)).BeginInit();
        this.SuspendLayout();
        // 
        // appLogSplitter
        // 
        this.appLogSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
        this.appLogSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        this.appLogSplitter.IsSplitterFixed = true;
        this.appLogSplitter.Location = new System.Drawing.Point(0, 0);
        this.appLogSplitter.Name = "appLogSplitter";
        this.appLogSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
        // 
        // appLogSplitter.Panel1
        // 
        this.appLogSplitter.Panel1.Controls.Add(this.btnProcessPictures);
        this.appLogSplitter.Panel1.Controls.Add(this.cbxShowLog);
        this.appLogSplitter.Panel1.Controls.Add(this.txtSourceFolder);
        this.appLogSplitter.Panel1.Controls.Add(this.hourModifier);
        this.appLogSplitter.Panel1.Controls.Add(this.txtVerticalOffset);
        this.appLogSplitter.Panel1.Controls.Add(this.label1);
        this.appLogSplitter.Panel1.Controls.Add(this.lblPictureSource);
        this.appLogSplitter.Panel1.Controls.Add(this.cbxAddDate);
        this.appLogSplitter.Panel1.Controls.Add(this.label3);
        this.appLogSplitter.Panel1.Controls.Add(this.btnChooseColor);
        this.appLogSplitter.Panel1.Controls.Add(this.progressBar1);
        this.appLogSplitter.Panel1.Controls.Add(this.lblDateSize);
        this.appLogSplitter.Panel1.Controls.Add(this.label2);
        this.appLogSplitter.Panel1.Controls.Add(this.txtColor);
        this.appLogSplitter.Panel1.Controls.Add(this.lblProgressText);
        this.appLogSplitter.Panel1.Controls.Add(this.dateTimeSizeBar);
        this.appLogSplitter.Panel1.Controls.Add(this.txtHorizontalOffset);
        this.appLogSplitter.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        // 
        // appLogSplitter.Panel2
        // 
        this.appLogSplitter.Panel2.AutoScroll = true;
        this.appLogSplitter.Panel2.Controls.Add(this.txtLogger);
        this.appLogSplitter.Size = new System.Drawing.Size(832, 506);
        this.appLogSplitter.SplitterDistance = 242;
        this.appLogSplitter.TabIndex = 24;
        // 
        // btnProcessPictures
        // 
        this.btnProcessPictures.Location = new System.Drawing.Point(700, 161);
        this.btnProcessPictures.Name = "btnProcessPictures";
        this.btnProcessPictures.Size = new System.Drawing.Size(113, 23);
        this.btnProcessPictures.TabIndex = 24;
        this.btnProcessPictures.Text = "Process Pictrues";
        this.btnProcessPictures.UseVisualStyleBackColor = true;
        this.btnProcessPictures.Click += new System.EventHandler(this.btnProcessPictures_Click);
        // 
        // cbxShowLog
        // 
        this.cbxShowLog.AutoSize = true;
        this.cbxShowLog.Location = new System.Drawing.Point(11, 219);
        this.cbxShowLog.Name = "cbxShowLog";
        this.cbxShowLog.Size = new System.Drawing.Size(74, 17);
        this.cbxShowLog.TabIndex = 40;
        this.cbxShowLog.Text = "Show Log";
        this.cbxShowLog.UseVisualStyleBackColor = true;
        this.cbxShowLog.CheckedChanged += new System.EventHandler(this.cbxShowLog_CheckedChanged);
        // 
        // txtSourceFolder
        // 
        this.txtSourceFolder.Controls.Add(this.btnBrowseSourceFolder);
        this.txtSourceFolder.Location = new System.Drawing.Point(175, 30);
        this.txtSourceFolder.Name = "txtSourceFolder";
        this.txtSourceFolder.Size = new System.Drawing.Size(640, 20);
        this.txtSourceFolder.TabIndex = 25;
        // 
        // btnBrowseSourceFolder
        // 
        this.btnBrowseSourceFolder.Dock = System.Windows.Forms.DockStyle.Right;
        this.btnBrowseSourceFolder.Location = new System.Drawing.Point(561, 0);
        this.btnBrowseSourceFolder.Name = "btnBrowseSourceFolder";
        this.btnBrowseSourceFolder.Size = new System.Drawing.Size(75, 16);
        this.btnBrowseSourceFolder.TabIndex = 5;
        this.btnBrowseSourceFolder.Text = "...";
        this.btnBrowseSourceFolder.UseVisualStyleBackColor = true;
        // 
        // hourModifier
        // 
        this.hourModifier.Location = new System.Drawing.Point(270, 75);
        this.hourModifier.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
        this.hourModifier.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
        this.hourModifier.Name = "hourModifier";
        this.hourModifier.Size = new System.Drawing.Size(63, 20);
        this.hourModifier.TabIndex = 32;
        this.hourModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // txtVerticalOffset
        // 
        this.txtVerticalOffset.BackColor = System.Drawing.Color.White;
        this.txtVerticalOffset.Location = new System.Drawing.Point(669, 106);
        this.txtVerticalOffset.Name = "txtVerticalOffset";
        this.txtVerticalOffset.Size = new System.Drawing.Size(100, 20);
        this.txtVerticalOffset.TabIndex = 39;
        this.txtVerticalOffset.Text = "0";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(329, 57);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(106, 13);
        this.label1.TabIndex = 33;
        this.label1.Text = "Change picture  hour";
        // 
        // lblPictureSource
        // 
        this.lblPictureSource.AutoSize = true;
        this.lblPictureSource.Location = new System.Drawing.Point(8, 13);
        this.lblPictureSource.Name = "lblPictureSource";
        this.lblPictureSource.Size = new System.Drawing.Size(76, 13);
        this.lblPictureSource.TabIndex = 26;
        this.lblPictureSource.Text = "Source Folder:";
        // 
        // cbxAddDate
        // 
        this.cbxAddDate.AutoSize = true;
        this.cbxAddDate.Checked = true;
        this.cbxAddDate.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbxAddDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.cbxAddDate.Location = new System.Drawing.Point(167, 55);
        this.cbxAddDate.Name = "cbxAddDate";
        this.cbxAddDate.Size = new System.Drawing.Size(74, 18);
        this.cbxAddDate.TabIndex = 31;
        this.cbxAddDate.Text = "add date";
        this.cbxAddDate.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(580, 89);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(73, 13);
        this.label3.TabIndex = 38;
        this.label3.Text = "Vertical Offset";
        // 
        // btnChooseColor
        // 
        this.btnChooseColor.Location = new System.Drawing.Point(176, 106);
        this.btnChooseColor.Name = "btnChooseColor";
        this.btnChooseColor.Size = new System.Drawing.Size(75, 23);
        this.btnChooseColor.TabIndex = 34;
        this.btnChooseColor.Text = "Color";
        this.btnChooseColor.UseVisualStyleBackColor = true;
        // 
        // progressBar1
        // 
        this.progressBar1.Location = new System.Drawing.Point(43, 205);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new System.Drawing.Size(770, 11);
        this.progressBar1.TabIndex = 27;
        // 
        // lblDateSize
        // 
        this.lblDateSize.AutoSize = true;
        this.lblDateSize.Location = new System.Drawing.Point(8, 146);
        this.lblDateSize.Name = "lblDateSize";
        this.lblDateSize.Size = new System.Drawing.Size(157, 13);
        this.lblDateSize.TabIndex = 30;
        this.lblDateSize.Text = "Date Size (Height 5% of picture)";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(378, 89);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(85, 13);
        this.label2.TabIndex = 37;
        this.label2.Text = "Horizontal Offset";
        // 
        // txtColor
        // 
        this.txtColor.BackColor = System.Drawing.Color.White;
        this.txtColor.Location = new System.Drawing.Point(270, 106);
        this.txtColor.Name = "txtColor";
        this.txtColor.ReadOnly = true;
        this.txtColor.Size = new System.Drawing.Size(100, 20);
        this.txtColor.TabIndex = 35;
        // 
        // lblProgressText
        // 
        this.lblProgressText.AutoSize = true;
        this.lblProgressText.BackColor = System.Drawing.Color.Transparent;
        this.lblProgressText.Location = new System.Drawing.Point(8, 185);
        this.lblProgressText.Name = "lblProgressText";
        this.lblProgressText.Size = new System.Drawing.Size(21, 13);
        this.lblProgressText.TabIndex = 28;
        this.lblProgressText.Text = "0%";
        // 
        // dateTimeSizeBar
        // 
        this.dateTimeSizeBar.Location = new System.Drawing.Point(175, 156);
        this.dateTimeSizeBar.Maximum = 20;
        this.dateTimeSizeBar.Minimum = 5;
        this.dateTimeSizeBar.Name = "dateTimeSizeBar";
        this.dateTimeSizeBar.Size = new System.Drawing.Size(500, 45);
        this.dateTimeSizeBar.TabIndex = 29;
        this.dateTimeSizeBar.Value = 7;
        // 
        // txtHorizontalOffset
        // 
        this.txtHorizontalOffset.BackColor = System.Drawing.Color.White;
        this.txtHorizontalOffset.Location = new System.Drawing.Point(479, 106);
        this.txtHorizontalOffset.Name = "txtHorizontalOffset";
        this.txtHorizontalOffset.Size = new System.Drawing.Size(100, 20);
        this.txtHorizontalOffset.TabIndex = 36;
        this.txtHorizontalOffset.Text = "0";
        // 
        // txtLogger
        // 
        this.txtLogger.BackColor = System.Drawing.SystemColors.ControlLightLight;
        this.txtLogger.Dock = System.Windows.Forms.DockStyle.Fill;
        this.txtLogger.Location = new System.Drawing.Point(0, 0);
        this.txtLogger.Multiline = true;
        this.txtLogger.Name = "txtLogger";
        this.txtLogger.ReadOnly = true;
        this.txtLogger.Size = new System.Drawing.Size(832, 260);
        this.txtLogger.TabIndex = 0;
        // 
        // RenamePictureMainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(832, 506);
        this.Controls.Add(this.appLogSplitter);
        this.Name = "RenamePictureMainForm";
        this.Text = "Add Date";
        this.appLogSplitter.Panel1.ResumeLayout(false);
        this.appLogSplitter.Panel1.PerformLayout();
        this.appLogSplitter.Panel2.ResumeLayout(false);
        this.appLogSplitter.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.appLogSplitter)).EndInit();
        this.appLogSplitter.ResumeLayout(false);
        this.txtSourceFolder.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.hourModifier)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dateTimeSizeBar)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.SplitContainer appLogSplitter;
    private System.Windows.Forms.Button btnProcessPictures;
    private System.Windows.Forms.CheckBox cbxShowLog;
    private System.Windows.Forms.TextBox txtSourceFolder;
    private System.Windows.Forms.Button btnBrowseSourceFolder;
    private System.Windows.Forms.NumericUpDown hourModifier;
    private System.Windows.Forms.TextBox txtVerticalOffset;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPictureSource;
    private System.Windows.Forms.CheckBox cbxAddDate;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnChooseColor;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label lblDateSize;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.Label lblProgressText;
    private System.Windows.Forms.TrackBar dateTimeSizeBar;
    private System.Windows.Forms.TextBox txtHorizontalOffset;
    private System.Windows.Forms.TextBox txtLogger;
  }
}

