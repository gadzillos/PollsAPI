using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollsAPI.DAL.Domain
{
    public class Poll
    {
        public static int idCounter = 0;
        public int Id { get; set; }
        public string Question { get; set; }
        public Status Status { get; set; }
        public SortedDictionary<int, string> Answers { get; set; }
        public Dictionary<string, int> Votes { get; set; }
        public string Creator { get; set; }

        public Poll(string question, SortedDictionary<int, string> answers, string creator)
        {
            checked
            {
                idCounter++;
            }
            this.Id = idCounter;
            this.Status = Status.Unpublished;
            this.Answers = answers;
            this.Creator = creator;
        }
    }
}
