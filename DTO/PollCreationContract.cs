using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollsAPI.DTO
{
    public class PollCreationContract
    {
        [JsonProperty("Question")]
        public string question;

        [JsonProperty("Answers")]
        public List<string> answers;
    }
}
