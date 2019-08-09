using System.Collections.Generic;

namespace Card

{
    public class Deck
    {

        List<CombatCard> combatCards;
        List<SpecialCard> specialCards;

        public void AddCombatCard(CombatCard combatCard)
        {

        }

        public void AddSpecialCard(SpecialCard specialCard)
        {

        }

        public void DestroyCombatCard(int cardId)
        {

        }

        public void DestroySpecialCard(int cardId)
        {

        }

        public void Shuffle()
        {

        }

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value }

        public Deck()
        {

        }
    }
}