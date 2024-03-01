namespace BookManagementApp
{
    partial class frmMain
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnDisplayBooks = new System.Windows.Forms.Button();
            this.btnWriteCsv = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(22, 41);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Enabled = false;
            this.btnReadFile.Location = new System.Drawing.Point(22, 120);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(118, 49);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnDisplayBooks
            // 
            this.btnDisplayBooks.Enabled = false;
            this.btnDisplayBooks.Location = new System.Drawing.Point(22, 201);
            this.btnDisplayBooks.Name = "btnDisplayBooks";
            this.btnDisplayBooks.Size = new System.Drawing.Size(118, 49);
            this.btnDisplayBooks.TabIndex = 2;
            this.btnDisplayBooks.Text = "Display Books";
            this.btnDisplayBooks.UseVisualStyleBackColor = true;
            this.btnDisplayBooks.Click += new System.EventHandler(this.btnDisplayBooks_Click);
            // 
            // btnWriteCsv
            // 
            this.btnWriteCsv.Enabled = false;
            this.btnWriteCsv.Location = new System.Drawing.Point(22, 285);
            this.btnWriteCsv.Name = "btnWriteCsv";
            this.btnWriteCsv.Size = new System.Drawing.Size(118, 49);
            this.btnWriteCsv.TabIndex = 3;
            this.btnWriteCsv.Text = "Write Csv";
            this.btnWriteCsv.UseVisualStyleBackColor = true;
            this.btnWriteCsv.Click += new System.EventHandler(this.btnWriteCsv_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(226, 41);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(502, 380);
            this.txtOutput.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnWriteCsv);
            this.Controls.Add(this.btnDisplayBooks);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmMain";
            this.Text = "File I/O";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnDisplayBooks;
        private System.Windows.Forms.Button btnWriteCsv;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnExit;
    }
}

