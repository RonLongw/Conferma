using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RandomNumbers;
using PayTask.ViewModels;

namespace PayTask
{
    public partial class PayTaskForm : Form
    {
        private int CurrentValue { get; set; }
        private int CurrentScore { get; set; }
        private List<HighScoreViewModel> HighScores;
        private int ElapsedTimeInMilliseconds { get; set; }
        private System.Diagnostics.Stopwatch Watch { get; set; }

        public PayTaskForm()
        {
            InitializeComponent();

            Initialise();
        }

        private void btnGenerateNumber_Click(object sender, EventArgs e)
        {
            SetScore();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Watch = System.Diagnostics.Stopwatch.StartNew();
            Reset();
        }

        private void Initialise()
        {
            btnGenerateNumber.Enabled = false;
            HighScores = new List<HighScoreViewModel>();
            CurrentValue = 0;
            CurrentScore = 0;
            rbHigher.Checked = true;
        }

        private void Reset()
        {
            CurrentValue = 0;
            CurrentScore = 0;
            txtRandomNumber.Text = string.Empty;
            txtScore.Text = string.Empty;

            rbHigher.Checked = true;

            btnGenerateNumber.Enabled = true;
        }

        //Could be moved to separate class to keep display layer trim
        private bool CorrectAnswer(int currentVal, int newVal)
        {
            bool retVal = false;

            if (rbHigher.Checked)
            {
                if (newVal > currentVal)
                {
                    retVal = true;
                }
            }
            else
            {
                if (newVal < currentVal)
                {
                    retVal = true;
                }
            }

            return retVal;
        }

        //Could be moved to separate class to keep display layer trim
        private bool IsHighScore(List<HighScoreViewModel> highScores, int scoreValue)
        {
            var retVal = false;

            if ((highScores == null) || (highScores.Count == 0))
            {
                retVal = true;
            }
            else
            {
                var isHighScore = highScores.Where(x => x.Score < scoreValue);

                retVal = isHighScore.Any();
            }

            return retVal;
        }

        //Could be moved to separate class to keep display layer trim
        private bool HasEqualHighScore(List<HighScoreViewModel> highScores, int scoreValue)
        {
            var retVal = false;

            if ((highScores == null) || (highScores.Count == 0))
            {
                retVal = false;
            }
            else
            {
                var isHighScore = highScores.Where(x => x.Score == scoreValue);

                retVal = isHighScore.Any();
            }

            return retVal;
        }

        private void SetScore()
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("You must fill in the user name field to continue");
                return;
            }

            var rand = new RandomNumbers.RandomNumber();

            var number = rand.GenerateRandomInteger(1, 100);
            txtRandomNumber.Text = number.ToString();

            if (CurrentValue > 0)  
            {
                if (CorrectAnswer(CurrentValue, number))
                {
                    CurrentScore += 1;

                    if (CurrentScore == 10)
                    {
                        MessageBox.Show("Well done! You have completed the game.");
                        txtHighScores.Text = DisplayHighScores(HighScores);
                    }
                }
                else
                {
                    if ((CurrentScore > 0) && IsHighScore(HighScores, CurrentScore))
                    {
                        //if (!HasEqualHighScore(HighScores, CurrentScore))
                        //{
                            HighScores.Add(new HighScoreViewModel() { Score = CurrentScore, UserName = txtUserName.Text, ElapsedTimeInMilliseconds = Watch.ElapsedMilliseconds });
                        //}
                    }

                    btnGenerateNumber.Enabled = false;

                    Watch.Stop();

                    txtHighScores.Text =  DisplayHighScores(HighScores);
                }
                
            }

            txtScore.Text = CurrentScore == 0 ? string.Empty : CurrentScore.ToString();

            CurrentValue = number;
        }   
        
        // This could be moved to a separate class
        private string DisplayHighScores(List<HighScoreViewModel> highScores)
        {
            var sb = new StringBuilder();

            var sorted = highScores.OrderByDescending(x => x.Score).ThenByDescending(y => y.ElapsedTimeInMilliseconds).Take(3);

            foreach (var score in sorted)
            {
                sb.Append(score.UserName + " - " + score.Score.ToString() + " - " + score.ElapsedTimeInMilliseconds.ToString());
                sb.Append(System.Environment.NewLine);
            }

            return sb.ToString();
            
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == string.Empty)
            {
                MessageBox.Show("A file name is required!");
                return;
            }

            var file = new FileService.FileIO();

            file.WriteToTextFile(txtFileName.Text, txtHighScores.Text);
        }


        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            var file = new FileService.FileIO();

            if (File.Exists(txtFileName.Text))
            {
                txtHighScores.Text = string.Empty;
                var split = File.ReadLines(txtFileName.Text);

                if (split.Count() > 0)
                {
                    HighScores.Clear();
                    foreach (var line in split)
                    {
                        txtHighScores.Text += line + System.Environment.NewLine;
                        var splitLine = line.Replace(" ", "").Split('-');

                        HighScores.Add(new HighScoreViewModel() { Score = int.Parse(splitLine[1]), UserName = splitLine[0], ElapsedTimeInMilliseconds = long.Parse(splitLine[2]) });
                    }
                }
            }

        }
    }
}
