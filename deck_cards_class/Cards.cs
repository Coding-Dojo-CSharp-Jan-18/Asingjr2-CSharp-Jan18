using System;
using System.Collections.Generic;

namespace deck_cards_class
{
    // Creating Card class with public attributes
    public class Card{
        public string stringVal;
        public string suit;
        public int val;
        public Card(string st, string su, int v){
            stringVal = st;
            suit = su;
            val = v;
        }

    }
    // Creating Deck Class with several methods
        public class Deck{
        string[] suits =  { "hearts", "spades", "diamonds","clubs"};
        string[] stringvals = {
            "Ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King"};
        public List<Card> cards = new List<Card>();
        public void CreateDeck(){
            string stv_temp = " ";
            string suit_temp = " ";
            int val_temp = 0;
            for(int suit2 = 0; suit2< 4; suit2++){
                suit_temp = suits[suit2];
                for (int a = 0; a < stringvals.Length; a++)
                {
                    stv_temp = stringvals[a];
                    val_temp = a;
                    Card new_card =  new Card(stv_temp, suit_temp, val_temp);
                    cards.Add(new_card);
                }
            }
        }
        public object Deal(){
            if (cards.Count > 0){
                Card temp = cards[0];
                cards.RemoveAt(0);
                return temp;
            }
            return null;
        }

        public Deck Reset(){
        cards = new List<Card>();
        CreateDeck();
        return this;
        }

        public Deck Shuffle(){
            Random rand = new Random();
            for (int idx = cards.Count - 1; idx > 0; idx--)
            {
                int randIdx = rand.Next(idx);
                Card temp = cards[randIdx];
                cards[randIdx] = cards[idx];
                cards[idx] = temp;
            }
            return this;

        }
        }
        // Creating Player Class
        public class Player{
            public string name;
            public List<Card> hand;

            public void Draw(Deck currentDeck){
                Random rand = new Random();
                hand.Add(currentDeck.cards[rand.Next(currentDeck.cards.Count)]);
            }
            
            public Card Discard(int idx){
                Card temp = hand[idx];
                hand.RemoveAt(idx);
                return temp;
            }
        }
}

