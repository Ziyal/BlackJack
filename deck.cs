using System;
using System.Collections.Generic;

 namespace DeckOfCards {
    public class Deck{
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            createDeck();
        }

        private void createDeck(){
            cards = new List<Card>();
            string[] allSuits = { "Clubs", "Spades", "Hearts", "Diamonds" };
            int[] allVal = {2,3,4,5,6,7,8,9,10,10,10,10,11};
            string[] stringVal = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
            foreach (string suit in allSuits)
            {
                for (int i = 0; i < 13; i++)    {
                        cards.Add(new Card(allVal[i], stringVal[i], suit));
                }
            }
        }

        public Card Deal() {
            Card topCard = cards[0];
            cards.Remove(topCard);
            return topCard;
        }

        public void reset() {
            cards = new List<Card>();
            createDeck();
        }

        Random rand = new Random();
        public void shuffle() {
            for(int i = 0; i < cards.Count-1; i++){
                int randIdx = rand.Next(i, cards.Count);

                Card temp = cards[randIdx];
                cards[randIdx] = cards[i];
                cards[i] = temp;
            }
        }
    }
}


