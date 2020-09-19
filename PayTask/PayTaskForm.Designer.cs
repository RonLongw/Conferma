namespace PayTask
{
    partial class PayTaskForm
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
            this.txtRandomNumber = new System.Windows.Forms.TextBox();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.btnGenerateNumber = new System.Windows.Forms.Button();
            this.gpbHigherLower = new System.Windows.Forms.GroupBox();
            this.rbLower = new System.Windows.Forms.RadioButton();
            this.rbHigher = new System.Windows.Forms.RadioButton();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtHighScores = new System.Windows.Forms.TextBox();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnLoadResults = new System.Windows.Forms.Button();
            this.gpbHigherLower.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRandomNumber
            // 
            this.txtRandomNumber.Location = new System.Drawing.Point(174, 33);
            this.txtRandomNumber.Name = "txtRandomNumber";
            this.txtRandomNumber.ReadOnly = true;
            this.txtRandomNumber.Size = new System.Drawing.Size(194, 20);
            this.txtRandomNumber.TabIndex = 0;
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(30, 36);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(138, 13);
            this.lblRandomNumber.TabIndex = 1;
            this.lblRandomNumber.Text = "Random Number (1 to 100):";
            // 
            // btnGenerateNumber
            // 
            this.btnGenerateNumber.Location = new System.Drawing.Point(389, 33);
            this.btnGenerateNumber.Name = "btnGenerateNumber";
            this.btnGenerateNumber.Size = new System.Drawing.Size(163, 23);
            this.btnGenerateNumber.TabIndex = 2;
            this.btnGenerateNumber.Text = "Generate Random Number";
            this.btnGenerateNumber.UseVisualStyleBackColor = true;
            this.btnGenerateNumber.Click += new System.EventHandler(this.btnGenerateNumber_Click);
            // 
            // gpbHigherLower
            // 
            this.gpbHigherLower.Controls.Add(this.rbLower);
            this.gpbHigherLower.Controls.Add(this.rbHigher);
            this.gpbHigherLower.Location = new System.Drawing.Point(176, 80);
            this.gpbHigherLower.Name = "gpbHigherLower";
            this.gpbHigherLower.Size = new System.Drawing.Size(192, 41);
            this.gpbHigherLower.TabIndex = 3;
            this.gpbHigherLower.TabStop = false;
            // 
            // rbLower
            // 
            this.rbLower.AutoSize = true;
            this.rbLower.Location = new System.Drawing.Point(121, 18);
            this.rbLower.Name = "rbLower";
            this.rbLower.Size = new System.Drawing.Size(54, 17);
            this.rbLower.TabIndex = 1;
            this.rbLower.TabStop = true;
            this.rbLower.Text = "Lower";
            this.rbLower.UseVisualStyleBackColor = true;
            // 
            // rbHigher
            // 
            this.rbHigher.AutoSize = true;
            this.rbHigher.Location = new System.Drawing.Point(21, 18);
            this.rbHigher.Name = "rbHigher";
            this.rbHigher.Size = new System.Drawing.Size(56, 17);
            this.rbHigher.TabIndex = 0;
            this.rbHigher.TabStop = true;
            this.rbHigher.Text = "Higher";
            this.rbHigher.UseVisualStyleBackColor = true;
            // 
            // lblExplanation
            // 
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(22, 87);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(148, 82);
            this.lblExplanation.TabIndex = 4;
            this.lblExplanation.Text = "Select whether the next random number to be generated will be higher or lower tha" +
    "n the current number in the random number field";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(438, 105);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(56, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(419, 128);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(389, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Start";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(105, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(174, 9);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(194, 20);
            this.txtUserName.TabIndex = 9;
            // 
            // txtHighScores
            // 
            this.txtHighScores.Enabled = false;
            this.txtHighScores.Location = new System.Drawing.Point(90, 229);
            this.txtHighScores.Multiline = true;
            this.txtHighScores.Name = "txtHighScores";
            this.txtHighScores.Size = new System.Drawing.Size(398, 192);
            this.txtHighScores.TabIndex = 10;
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.Location = new System.Drawing.Point(96, 207);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(65, 13);
            this.lblHighScores.TabIndex = 11;
            this.lblHighScores.Text = "High Scores";
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Location = new System.Drawing.Point(514, 229);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(81, 23);
            this.btnSaveResults.TabIndex = 12;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(176, 205);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(311, 20);
            this.txtFileName.TabIndex = 13;
            this.txtFileName.Text = "C:\\Temp\\HighScores.txt";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(173, 189);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 14;
            this.lblFileName.Text = "File Name";
            // 
            // btnLoadResults
            // 
            this.btnLoadResults.Location = new System.Drawing.Point(514, 259);
            this.btnLoadResults.Name = "btnLoadResults";
            this.btnLoadResults.Size = new System.Drawing.Size(81, 23);
            this.btnLoadResults.TabIndex = 15;
            this.btnLoadResults.Text = "Load Results";
            this.btnLoadResults.UseVisualStyleBackColor = true;
            this.btnLoadResults.Click += new System.EventHandler(this.btnLoadResults_Click);
            // 
            // PayTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.btnLoadResults);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSaveResults);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.txtHighScores);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.gpbHigherLower);
            this.Controls.Add(this.btnGenerateNumber);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.txtRandomNumber);
            this.Name = "PayTaskForm";
            this.Text = "Pay Task";
            this.gpbHigherLower.ResumeLayout(false);
            this.gpbHigherLower.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRandomNumber;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button btnGenerateNumber;
        private System.Windows.Forms.GroupBox gpbHigherLower;
        private System.Windows.Forms.RadioButton rbLower;
        private System.Windows.Forms.RadioButton rbHigher;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtHighScores;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnLoadResults;
    }
}

