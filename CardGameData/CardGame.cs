using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CardGameData
{
    public class CardGame
    {
        [Key]
        public int GameNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<CardGuess> Guesses { get; set; } = new List<CardGuess>();
        public ulong? Winner { get; set; }
        public bool FirstGuess { get; set; }
        public bool LastCard { get; set; }
        public int WinsInARow { get; set; } = 0;
    }
}
