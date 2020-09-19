using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTask.ViewModels
{
    public class HighScoreViewModel
    {
        public string UserName { get; set; }
        public int Score { get; set; }
        public long ElapsedTimeInMilliseconds { get; set; }
    }
}
