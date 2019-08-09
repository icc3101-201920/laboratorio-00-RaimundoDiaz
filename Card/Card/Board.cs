using System.Collections.Generic;

namespace Card
{
    public class Board
    {
        List<CombatCard> meleeCards;
        List<CombatCard> rangeCards;
        List<CombatCard> longRagneCards;
        List<SpecialCard> specialMeleeCards;
        List<SpecialCard> specialRangeCards;
        List<SpecialCard> specialLongRangeCards;
        List<SpecialCard> captaincards;
        List<SpecialCard> weatherCards;

        public List<CombatCard> MeleeCards { get => meleeCards; }
        public List<CombatCard> RangeCards { get => rangeCards; }
        public List<CombatCard> LongRangeCards { get => longRagneCards; }
        public List<SpecialCard> SpecialMeleeCards { get => specialMeleeCards; }
        public List<SpecialCard> SpecialRangeCards { get => specialRangeCards; }
        public List<SpecialCard> SpecialLongRangeCards { get => specialLongRangeCards; }
        public List<SpecialCard> CaptainCards { get => captaincards; }
        public List<SpecialCard> WeatherCards { get => weatherCards; }

        public void Board()
        {

        }

    }
}