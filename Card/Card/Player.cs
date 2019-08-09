using System;

namespace Card
{
    public class Player
    {
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public void DrawCard()
        {

        }
        public void PlayCard(int cardID)
        {

        }
        public void ChangeCard(int cardID)
        {

        }
        public void FirstHand()
        {

        }
        public void ChooseCaptainCard(SpecialCard captainCard)
        {

        }

        public void AddComnatCard(int playerId, CombatCard combatCard)
        {

        }
        public void AddSpecialCard(int playerId, SpecialCard specialCard)
        {

        }
        public void DestroyCombatCards()
        {

        }

        public void DestroySpecialCards()
        {

        }

        public int[] GetMeleeAttackPoints()
        {

        }

        public int[] GetRangeAttackPoints()
        {

        }

        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int Attackpoints { get => attackPoints; set => attackPoints = value; }
        public Deck Deck { get; set; }
        public Hand Hand { get; set; }
        public SpecialCard Captain { get => captain; set => captain = value; }

        public  Player()
        {


        }
    }
}
