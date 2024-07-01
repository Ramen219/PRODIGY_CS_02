namespace ImageEncryptionTool
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
            label1 = new Label();
            txtInputPath = new TextBox();
            btnBrowseInput = new Button();
            label2 = new Label();
            txtOutputPath = new TextBox();
            btnBrowseOutput = new Button();
            label3 = new Label();
            txtKey = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(73, 245);
            label1.Name = "label1";
            label1.Size = new Size(245, 38);
            label1.TabIndex = 0;
            label1.Text = "Input Image Path";
            // 
            // txtInputPath
            // 
            txtInputPath.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtInputPath.Location = new Point(360, 242);
            txtInputPath.Name = "txtInputPath";
            txtInputPath.Size = new Size(189, 45);
            txtInputPath.TabIndex = 1;
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBrowseInput.Location = new Point(616, 242);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(156, 45);
            btnBrowseInput.TabIndex = 2;
            btnBrowseInput.Text = "Input";
            btnBrowseInput.UseVisualStyleBackColor = true;
            btnBrowseInput.Click += btnBrowseInput_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(73, 430);
            label2.Name = "label2";
            label2.Size = new Size(268, 38);
            label2.TabIndex = 3;
            label2.Text = "Output Image Path";
            // 
            // txtOutputPath
            // 
            txtOutputPath.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtOutputPath.Location = new Point(369, 430);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(189, 45);
            txtOutputPath.TabIndex = 4;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBrowseOutput.Location = new Point(616, 423);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(167, 45);
            btnBrowseOutput.TabIndex = 5;
            btnBrowseOutput.Text = "Output";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(73, 547);
            label3.Name = "label3";
            label3.Size = new Size(215, 38);
            label3.TabIndex = 6;
            label3.Text = "Encryption Key";
            // 
            // txtKey
            // 
            txtKey.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtKey.Location = new Point(300, 547);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(189, 45);
            txtKey.TabIndex = 7;
            txtKey.TextChanged += txtKey_TextChanged;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEncrypt.Location = new Point(312, 668);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(186, 69);
            btnEncrypt.TabIndex = 8;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click_1;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDecrypt.Location = new Point(616, 668);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(194, 69);
            btnDecrypt.TabIndex = 9;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1534, 122);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(73, 39);
            label4.Name = "label4";
            label4.Size = new Size(497, 38);
            label4.TabIndex = 0;
            label4.Text = "Simple Image Encryption Tool";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 788);
            Controls.Add(panel1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtKey);
            Controls.Add(label3);
            Controls.Add(btnBrowseOutput);
            Controls.Add(txtOutputPath);
            Controls.Add(label2);
            Controls.Add(btnBrowseInput);
            Controls.Add(txtInputPath);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Image Encryption ";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInputPath;
        private Button btnBrowseInput;
        private Label label2;
        private TextBox txtOutputPath;
        private Button btnBrowseOutput;
        private Label label3;
        private TextBox txtKey;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Panel panel1;
        private Label label4;
    }
}
