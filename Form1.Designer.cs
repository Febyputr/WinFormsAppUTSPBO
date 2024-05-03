namespace WinFormsAppUTSPBO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            printPreviewDialog1 = new PrintPreviewDialog();
            labelwelcome = new Label();
            checkBoxMahasiswa = new CheckBox();
            checkBoxDosen = new CheckBox();
            SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // labelwelcome
            // 
            labelwelcome.AutoSize = true;
            labelwelcome.BackColor = SystemColors.Menu;
            labelwelcome.FlatStyle = FlatStyle.System;
            labelwelcome.Font = new Font("Sitka Banner", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelwelcome.ForeColor = Color.MidnightBlue;
            labelwelcome.Location = new Point(303, 35);
            labelwelcome.Name = "labelwelcome";
            labelwelcome.Size = new Size(203, 68);
            labelwelcome.TabIndex = 0;
            labelwelcome.Text = "Welcome";
            labelwelcome.TextAlign = ContentAlignment.BottomCenter;
            labelwelcome.Click += label1_Click_1;
            // 
            // checkBoxMahasiswa
            // 
            checkBoxMahasiswa.AutoSize = true;
            checkBoxMahasiswa.Location = new Point(339, 168);
            checkBoxMahasiswa.Name = "checkBoxMahasiswa";
            checkBoxMahasiswa.Size = new Size(103, 24);
            checkBoxMahasiswa.TabIndex = 1;
            checkBoxMahasiswa.Text = "Mahasiswa";
            checkBoxMahasiswa.UseVisualStyleBackColor = true;
            checkBoxMahasiswa.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // checkBoxDosen
            // 
            checkBoxDosen.AutoSize = true;
            checkBoxDosen.Location = new Point(339, 229);
            checkBoxDosen.Name = "checkBoxDosen";
            checkBoxDosen.Size = new Size(73, 24);
            checkBoxDosen.TabIndex = 2;
            checkBoxDosen.Text = "Dosen";
            checkBoxDosen.UseVisualStyleBackColor = true;
            checkBoxDosen.CheckedChanged += checkBoxDosen_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxDosen);
            Controls.Add(checkBoxMahasiswa);
            Controls.Add(labelwelcome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Label labelwelcome;
        private CheckBox checkBoxMahasiswa;
        private CheckBox checkBoxDosen;
    }
}
