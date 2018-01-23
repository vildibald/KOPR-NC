namespace KOPR_Indexovac_klient
{
    partial class MainForm
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
            this.DocumentOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Input_TextBox = new System.Windows.Forms.TextBox();
            this.FindByComboBox = new System.Windows.Forms.ComboBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveIdsToFile_Button = new System.Windows.Forms.Button();
            this.LoadIdsFromFile_Button = new System.Windows.Forms.Button();
            this.DeleteFromFile_Button = new System.Windows.Forms.Button();
            this.GetDocuments_Button = new System.Windows.Forms.Button();
            this.Ids_TextBox = new System.Windows.Forms.TextBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocumentOpenFileDialog
            // 
            this.DocumentOpenFileDialog.FileName = "openFileDialog1";
            this.DocumentOpenFileDialog.Filter = "Text files|*.txt|All files|*.*";
            // 
            // Input_TextBox
            // 
            this.Input_TextBox.Enabled = false;
            this.Input_TextBox.Location = new System.Drawing.Point(6, 34);
            this.Input_TextBox.Name = "Input_TextBox";
            this.Input_TextBox.Size = new System.Drawing.Size(211, 20);
            this.Input_TextBox.TabIndex = 0;
            // 
            // FindByComboBox
            // 
            this.FindByComboBox.FormattingEnabled = true;
            this.FindByComboBox.Items.AddRange(new object[] {
            "words",
            "-"});
            this.FindByComboBox.Location = new System.Drawing.Point(6, 73);
            this.FindByComboBox.Name = "FindByComboBox";
            this.FindByComboBox.Size = new System.Drawing.Size(72, 21);
            this.FindByComboBox.TabIndex = 1;
            this.FindByComboBox.SelectedIndexChanged += new System.EventHandler(this.FindByComboBox_SelectedIndexChanged);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(84, 71);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(63, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Search";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(153, 71);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FindByComboBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FindButton);
            this.groupBox1.Controls.Add(this.Input_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search words:";
            // 
            // SaveIdsToFile_Button
            // 
            this.SaveIdsToFile_Button.Location = new System.Drawing.Point(239, 12);
            this.SaveIdsToFile_Button.Name = "SaveIdsToFile_Button";
            this.SaveIdsToFile_Button.Size = new System.Drawing.Size(75, 23);
            this.SaveIdsToFile_Button.TabIndex = 6;
            this.SaveIdsToFile_Button.Text = "Save";
            this.SaveIdsToFile_Button.UseVisualStyleBackColor = true;
            this.SaveIdsToFile_Button.Click += new System.EventHandler(this.SaveIdsToFile_Button_Click);
            // 
            // LoadIdsFromFile_Button
            // 
            this.LoadIdsFromFile_Button.Location = new System.Drawing.Point(239, 41);
            this.LoadIdsFromFile_Button.Name = "LoadIdsFromFile_Button";
            this.LoadIdsFromFile_Button.Size = new System.Drawing.Size(75, 23);
            this.LoadIdsFromFile_Button.TabIndex = 7;
            this.LoadIdsFromFile_Button.Text = "Load";
            this.LoadIdsFromFile_Button.UseVisualStyleBackColor = true;
            this.LoadIdsFromFile_Button.Click += new System.EventHandler(this.LoadIdsFromFile_Button_Click);
            // 
            // DeleteFromFile_Button
            // 
            this.DeleteFromFile_Button.Location = new System.Drawing.Point(239, 70);
            this.DeleteFromFile_Button.Name = "DeleteFromFile_Button";
            this.DeleteFromFile_Button.Size = new System.Drawing.Size(75, 23);
            this.DeleteFromFile_Button.TabIndex = 8;
            this.DeleteFromFile_Button.Text = "Del. file";
            this.DeleteFromFile_Button.UseVisualStyleBackColor = true;
            this.DeleteFromFile_Button.Click += new System.EventHandler(this.DeleteFromFile_Button_Click);
            // 
            // GetDocuments_Button
            // 
            this.GetDocuments_Button.Location = new System.Drawing.Point(239, 237);
            this.GetDocuments_Button.Name = "GetDocuments_Button";
            this.GetDocuments_Button.Size = new System.Drawing.Size(75, 39);
            this.GetDocuments_Button.TabIndex = 9;
            this.GetDocuments_Button.Text = "Get Documents";
            this.GetDocuments_Button.UseVisualStyleBackColor = true;
            this.GetDocuments_Button.Click += new System.EventHandler(this.GetDocuments_Button_Click);
            // 
            // Ids_TextBox
            // 
            this.Ids_TextBox.Location = new System.Drawing.Point(12, 12);
            this.Ids_TextBox.Multiline = true;
            this.Ids_TextBox.Name = "Ids_TextBox";
            this.Ids_TextBox.Size = new System.Drawing.Size(221, 156);
            this.Ids_TextBox.TabIndex = 10;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(239, 99);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 11;
            this.Clear_Button.Text = "Clear text";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 288);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Ids_TextBox);
            this.Controls.Add(this.GetDocuments_Button);
            this.Controls.Add(this.DeleteFromFile_Button);
            this.Controls.Add(this.SaveIdsToFile_Button);
            this.Controls.Add(this.LoadIdsFromFile_Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Kopr Document Indexer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog DocumentOpenFileDialog;
        private System.Windows.Forms.TextBox Input_TextBox;
        private System.Windows.Forms.ComboBox FindByComboBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveIdsToFile_Button;
        private System.Windows.Forms.Button LoadIdsFromFile_Button;
        private System.Windows.Forms.Button DeleteFromFile_Button;
        private System.Windows.Forms.Button GetDocuments_Button;
        private System.Windows.Forms.TextBox Ids_TextBox;
        private System.Windows.Forms.Button Clear_Button;
        
    }
}

