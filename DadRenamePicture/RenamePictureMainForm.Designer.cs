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
            this.lblPictureSource = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseSourceFolder = new System.Windows.Forms.Button();
            this.btnProcessPictures = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.dateTimeSizeBar = new System.Windows.Forms.TrackBar();
            this.lblDateSize = new System.Windows.Forms.Label();
            this.cbxAddDate = new System.Windows.Forms.CheckBox();
            this.hourModifier = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtHorizontalOffset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVerticalOffset = new System.Windows.Forms.TextBox();
            this.txtSourceFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPictureSource
            // 
            this.lblPictureSource.AutoSize = true;
            this.lblPictureSource.Location = new System.Drawing.Point(21, 15);
            this.lblPictureSource.Name = "lblPictureSource";
            this.lblPictureSource.Size = new System.Drawing.Size(76, 13);
            this.lblPictureSource.TabIndex = 8;
            this.lblPictureSource.Text = "Source Folder:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Controls.Add(this.btnBrowseSourceFolder);
            this.txtSourceFolder.Location = new System.Drawing.Point(178, 12);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(640, 20);
            this.txtSourceFolder.TabIndex = 6;
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
            this.btnBrowseSourceFolder.Click += new System.EventHandler(this.btnBrowseSourceFolder_Click);
            // 
            // btnProcessPictures
            // 
            this.btnProcessPictures.Location = new System.Drawing.Point(703, 143);
            this.btnProcessPictures.Name = "btnProcessPictures";
            this.btnProcessPictures.Size = new System.Drawing.Size(113, 23);
            this.btnProcessPictures.TabIndex = 5;
            this.btnProcessPictures.Text = "Process Pictrues";
            this.btnProcessPictures.UseVisualStyleBackColor = true;
            this.btnProcessPictures.Click += new System.EventHandler(this.btnProcessPictures_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(46, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 11);
            this.progressBar1.TabIndex = 10;
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressText.Location = new System.Drawing.Point(21, 187);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(21, 13);
            this.lblProgressText.TabIndex = 11;
            this.lblProgressText.Text = "0%";
            // 
            // dateTimeSizeBar
            // 
            this.dateTimeSizeBar.Location = new System.Drawing.Point(178, 138);
            this.dateTimeSizeBar.Maximum = 20;
            this.dateTimeSizeBar.Minimum = 5;
            this.dateTimeSizeBar.Name = "dateTimeSizeBar";
            this.dateTimeSizeBar.Size = new System.Drawing.Size(500, 45);
            this.dateTimeSizeBar.TabIndex = 12;
            this.dateTimeSizeBar.Value = 7;
            this.dateTimeSizeBar.Scroll += new System.EventHandler(this.dateTimeSizeBar_Scroll);
            // 
            // lblDateSize
            // 
            this.lblDateSize.AutoSize = true;
            this.lblDateSize.Location = new System.Drawing.Point(21, 148);
            this.lblDateSize.Name = "lblDateSize";
            this.lblDateSize.Size = new System.Drawing.Size(157, 13);
            this.lblDateSize.TabIndex = 13;
            this.lblDateSize.Text = "Date Size (Height 5% of picture)";
            // 
            // cbxAddDate
            // 
            this.cbxAddDate.AutoSize = true;
            this.cbxAddDate.Checked = true;
            this.cbxAddDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAddDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxAddDate.Location = new System.Drawing.Point(180, 57);
            this.cbxAddDate.Name = "cbxAddDate";
            this.cbxAddDate.Size = new System.Drawing.Size(74, 18);
            this.cbxAddDate.TabIndex = 14;
            this.cbxAddDate.Text = "add date";
            this.cbxAddDate.UseVisualStyleBackColor = true;
            // 
            // hourModifier
            // 
            this.hourModifier.Location = new System.Drawing.Point(273, 57);
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
            this.hourModifier.TabIndex = 15;
            this.hourModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Change picture  hour";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(179, 88);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(75, 23);
            this.btnChooseColor.TabIndex = 17;
            this.btnChooseColor.Text = "Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(273, 88);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 18;
            // 
            // txtHorizontalOffset
            // 
            this.txtHorizontalOffset.BackColor = System.Drawing.Color.White;
            this.txtHorizontalOffset.Location = new System.Drawing.Point(482, 88);
            this.txtHorizontalOffset.Name = "txtHorizontalOffset";
            this.txtHorizontalOffset.Size = new System.Drawing.Size(100, 20);
            this.txtHorizontalOffset.TabIndex = 19;
            this.txtHorizontalOffset.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Horizontal Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vertical Offset";
            // 
            // txtVerticalOffset
            // 
            this.txtVerticalOffset.BackColor = System.Drawing.Color.White;
            this.txtVerticalOffset.Location = new System.Drawing.Point(672, 88);
            this.txtVerticalOffset.Name = "txtVerticalOffset";
            this.txtVerticalOffset.Size = new System.Drawing.Size(100, 20);
            this.txtVerticalOffset.TabIndex = 22;
            this.txtVerticalOffset.Text = "0";
            // 
            // RenamePictureMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 250);
            this.Controls.Add(this.txtVerticalOffset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHorizontalOffset);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourModifier);
            this.Controls.Add(this.cbxAddDate);
            this.Controls.Add(this.lblDateSize);
            this.Controls.Add(this.dateTimeSizeBar);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPictureSource);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.btnProcessPictures);
            this.Name = "RenamePictureMainForm";
            this.Text = "Add Date";
            this.txtSourceFolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label lblPictureSource;
    private System.Windows.Forms.TextBox txtSourceFolder;
    private System.Windows.Forms.Button btnBrowseSourceFolder;
    private System.Windows.Forms.Button btnProcessPictures;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label lblProgressText;
    private System.Windows.Forms.TrackBar dateTimeSizeBar;
    private System.Windows.Forms.Label lblDateSize;
    private System.Windows.Forms.CheckBox cbxAddDate;
    private System.Windows.Forms.NumericUpDown hourModifier;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button btnChooseColor;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.TextBox txtHorizontalOffset;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtVerticalOffset;
  }
}

