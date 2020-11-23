using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGameData
{
    public enum PlayingCard
    {
        CA,
        C2,
        C3,
        C4,
        C5,
        C6,
        C7,
        C8,
        C9,
        C10,
        CJ,
        CQ,
        CK,
        DA,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        D10,
        DJ,
        DQ,
        DK,
        HA,
        H2,
        H3,
        H4,
        H5,
        H6,
        H7,
        H8,
        H9,
        H10,
        HJ,
        HQ,
        HK,
        SA,
        S2,
        S3,
        S4,
        S5,
        S6,
        S7,
        S8,
        S9,
        S10,
        SJ,
        SQ,
        SK
    }

    public static class CardConverter
    {
        public static readonly IReadOnlyDictionary<PlayingCard, string> LongStrings = new Dictionary<PlayingCard, string>()
        {
            { PlayingCard.CA, "Ace of Clubs" },
            { PlayingCard.C2, "Two of Clubs" },
            { PlayingCard.C3, "Three of Clubs" },
            { PlayingCard.C4, "Four of Clubs" },
            { PlayingCard.C5, "Five of Clubs" },
            { PlayingCard.C6, "Six of Clubs" },
            { PlayingCard.C7, "Seven of Clubs" },
            { PlayingCard.C8, "Eight of Clubs" },
            { PlayingCard.C9, "Nine of Clubs" },
            { PlayingCard.C10, "Ten of Clubs" },
            { PlayingCard.CJ, "Jack of Clubs" },
            { PlayingCard.CQ, "Queen of Clubs" },
            { PlayingCard.CK, "King of Clubs" },
            { PlayingCard.DA, "Ace of Diamonds" },
            { PlayingCard.D2, "Two of Diamonds" },
            { PlayingCard.D3, "Three of Diamonds" },
            { PlayingCard.D4, "Four of Diamonds" },
            { PlayingCard.D5, "Five of Diamonds" },
            { PlayingCard.D6, "Six of Diamonds" },
            { PlayingCard.D7, "Seven of Diamonds" },
            { PlayingCard.D8, "Eight of Diamonds" },
            { PlayingCard.D9, "Nine of Diamonds" },
            { PlayingCard.D10, "Ten of Diamonds" },
            { PlayingCard.DJ, "Jack of Diamonds" },
            { PlayingCard.DQ, "Queen of Diamonds" },
            { PlayingCard.DK, "King of Diamonds" },
            { PlayingCard.HA, "Ace of Hearts" },
            { PlayingCard.H2, "Two of Hearts" },
            { PlayingCard.H3, "Three of Hearts" },
            { PlayingCard.H4, "Four of Hearts" },
            { PlayingCard.H5, "Five of Hearts" },
            { PlayingCard.H6, "Six of Hearts" },
            { PlayingCard.H7, "Seven of Hearts" },
            { PlayingCard.H8, "Eight of Hearts" },
            { PlayingCard.H9, "Nine of Hearts" },
            { PlayingCard.H10, "Ten of Hearts" },
            { PlayingCard.HJ, "Jack of Hearts" },
            { PlayingCard.HQ, "Queen of Hearts" },
            { PlayingCard.HK, "King of Hearts" },
            { PlayingCard.SA, "Ace of Spades" },
            { PlayingCard.S2, "Two of Spades" },
            { PlayingCard.S3, "Three of Spades" },
            { PlayingCard.S4, "Four of Spades" },
            { PlayingCard.S5, "Five of Spades" },
            { PlayingCard.S6, "Six of Spades" },
            { PlayingCard.S7, "Seven of Spades" },
            { PlayingCard.S8, "Eight of Spades" },
            { PlayingCard.S9, "Nine of Spades" },
            { PlayingCard.S10, "Ten of Spades" },
            { PlayingCard.SJ, "Jack of Spades" },
            { PlayingCard.SQ, "Queen of Spades" },
            { PlayingCard.SK, "King of Spades" },
        };

        public static readonly IReadOnlyDictionary<PlayingCard, string> ShortStrings = new Dictionary<PlayingCard, string>()
        {
            { PlayingCard.CA, "AC" },
            { PlayingCard.C2, "2C" },
            { PlayingCard.C3, "3C" },
            { PlayingCard.C4, "4C" },
            { PlayingCard.C5, "5C" },
            { PlayingCard.C6, "6C" },
            { PlayingCard.C7, "7C" },
            { PlayingCard.C8, "8C" },
            { PlayingCard.C9, "9C" },
            { PlayingCard.C10, "10C" },
            { PlayingCard.CJ, "JC" },
            { PlayingCard.CQ, "QC" },
            { PlayingCard.CK, "KC" },
            { PlayingCard.DA, "AD" },
            { PlayingCard.D2, "2D" },
            { PlayingCard.D3, "3D" },
            { PlayingCard.D4, "4D" },
            { PlayingCard.D5, "5D" },
            { PlayingCard.D6, "6D" },
            { PlayingCard.D7, "7D" },
            { PlayingCard.D8, "8D" },
            { PlayingCard.D9, "9D" },
            { PlayingCard.D10, "10D" },
            { PlayingCard.DJ, "JD" },
            { PlayingCard.DQ, "QD" },
            { PlayingCard.DK, "KD" },
            { PlayingCard.HA, "AH" },
            { PlayingCard.H2, "2H" },
            { PlayingCard.H3, "3H" },
            { PlayingCard.H4, "4H" },
            { PlayingCard.H5, "5H" },
            { PlayingCard.H6, "6H" },
            { PlayingCard.H7, "7H" },
            { PlayingCard.H8, "8H" },
            { PlayingCard.H9, "9H" },
            { PlayingCard.H10, "10H" },
            { PlayingCard.HJ, "JH" },
            { PlayingCard.HQ, "QH" },
            { PlayingCard.HK, "KH" },
            { PlayingCard.SA, "AS" },
            { PlayingCard.S2, "2S" },
            { PlayingCard.S3, "3S" },
            { PlayingCard.S4, "4S" },
            { PlayingCard.S5, "5S" },
            { PlayingCard.S6, "6S" },
            { PlayingCard.S7, "7S" },
            { PlayingCard.S8, "8S" },
            { PlayingCard.S9, "9S" },
            { PlayingCard.S10, "10S" },
            { PlayingCard.SJ, "JS" },
            { PlayingCard.SQ, "QS" },
            { PlayingCard.SK, "KS" },
        };

        public static string? ToLongString(this PlayingCard card)
            => LongStrings.TryGetValue(card, out var res) ? res : null;

        public static string? ToShortString(this PlayingCard card)
            => ShortStrings.TryGetValue(card, out var res) ? res : null;

        public static bool TryParse(string value, out PlayingCard? card)
        {
            var shorts = ShortStrings.ToArray();
            var longs = LongStrings.ToArray();

            for(int i = 0; i < ShortStrings.Count; i++)
            {
                if (shorts[i].Value.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    card = shorts[i].Key;
                    return true;
                }
                
                if(longs[i].Value.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    card = longs[i].Key;
                    return true;
                }
            }

            card = null;
            return false;
        }
    }
}
