 namespace DeckOfCards {
    public class Card{      
        public string stringVal; 

        public string suit;

        public int val;
        
        public Card(int v, string sv, string s) {
            stringVal = sv;
            val = v;
            suit = s;
        }

    }
}