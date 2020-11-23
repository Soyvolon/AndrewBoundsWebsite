using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameData
{
    public class CardGuess
    {
        [Key]
        public int GuessId { get; set; }
        public CloudTeam Team { get; set; }
        public ulong UserId { get; set; }
        public PlayingCard Card { get; set; }
        public DateTime GuessedOn { get; set; }
    }
}
