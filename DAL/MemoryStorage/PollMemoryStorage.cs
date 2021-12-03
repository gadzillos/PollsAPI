using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PollsAPI.DAL.Domain;

namespace PollsAPI.DAL.MemoryStorage
{
    public class PollMemoryStorage : IPollStorage
    {
        private readonly List<Poll> _polls;

        public PollMemoryStorage()
        {
            _polls = new List<Poll>();
        }

        public void Add(string question, SortedDictionary<int, string> answers, string creator)
        {
            _polls.Add(new Poll(question, answers, creator));
        }
    }
}
