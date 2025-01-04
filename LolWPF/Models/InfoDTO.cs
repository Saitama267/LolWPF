using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolWPF.Models
{
    public class InfoDTO
    {
        public string GameMode { get; set; }
        public string GameType { get; set; }
        public List<ParticipantDto> Participants { get; set; }
    }
}
