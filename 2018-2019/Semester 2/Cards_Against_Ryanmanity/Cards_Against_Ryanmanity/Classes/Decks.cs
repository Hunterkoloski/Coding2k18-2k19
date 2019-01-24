using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Against_Ryanmanity.Classes
{
    class Decks
    {
        List<Cards> deck = new List<Cards>();
        List<Cards> discard = new List<Cards>();
        public void shuffle()
        {
            deck.Add(new Cards("Ace", "Spades"));
            deck.Add(new Cards("Two", "Spades"));
            deck.Add(new Cards("Three", "Spades"));
            deck.Add(new Cards("Four", "Spades"));
            deck.Add(new Cards("Five", "Spades"));
            deck.Add(new Cards("Six", "Spades"));
            deck.Add(new Cards("Seven", "Spades"));
            deck.Add(new Cards("Eight", "Spades"));
            deck.Add(new Cards("Nine", "Spades"));
            deck.Add(new Cards("Ten", "Spades"));
            deck.Add(new Cards("Jack", "Spades"));
            deck.Add(new Cards("Queen", "Spades"));
            deck.Add(new Cards("King", "Spades"));
            deck.Add(new Cards("Ace", "Clubs"));
            deck.Add(new Cards("Two", "Clubs"));
            deck.Add(new Cards("Three", "Clubs"));
            deck.Add(new Cards("Four", "Clubs"));
            deck.Add(new Cards("Five", "Clubs"));
            deck.Add(new Cards("Six", "Clubs"));
            deck.Add(new Cards("Seven", "Clubs"));
            deck.Add(new Cards("Eight", "Clubs"));
            deck.Add(new Cards("Nine", "Clubs"));
            deck.Add(new Cards("Ten", "Clubs"));
            deck.Add(new Cards("Jack", "Clubs"));
            deck.Add(new Cards("Queen", "Clubs"));
            deck.Add(new Cards("King", "Clubs"));
            deck.Add(new Cards("Ace", "Diamonds"));
            deck.Add(new Cards("Two", "Diamonds"));
            deck.Add(new Cards("Three", "Diamonds"));
            deck.Add(new Cards("Four", "Diamonds"));
            deck.Add(new Cards("Five", "Diamonds"));
            deck.Add(new Cards("Six", "Diamonds"));
            deck.Add(new Cards("Seven", "Diamonds"));
            deck.Add(new Cards("Eight", "Diamonds"));
            deck.Add(new Cards("Nine", "Diamonds"));
            deck.Add(new Cards("Ten", "Diamonds"));
            deck.Add(new Cards("Jack", "Diamonds"));
            deck.Add(new Cards("Queen", "Diamonds"));
            deck.Add(new Cards("King", "Diamonds"));
            deck.Add(new Cards("Ace", "Hearts"));
            deck.Add(new Cards("Two", "Hearts"));
            deck.Add(new Cards("Three", "Hearts"));
            deck.Add(new Cards("Four", "Hearts"));
            deck.Add(new Cards("Five", "Hearts"));
            deck.Add(new Cards("Six", "Hearts"));
            deck.Add(new Cards("Seven", "Hearts"));
            deck.Add(new Cards("Eight", "Hearts"));
            deck.Add(new Cards("Nine", "Hearts"));
            deck.Add(new Cards("Ten", "Hearts"));
            deck.Add(new Cards("Jack", "Hearts"));
            deck.Add(new Cards("Queen", "Hearts"));
            deck.Add(new Cards("King", "Hearts"));
            Random rand = new Random();

            deck = deck.OrderBy(t => rand.Next()).ToList();
            discard.Clear();
        }
        public Cards Draw()
        {
            if (deck.Count > 1)
            {
                Cards bad = deck[deck.Count - 1];
                deck.RemoveAt(deck.Count - 1);
                return bad;
            }
            else
                return null;
        }
        public void Discard(Cards c)
        {
            discard.Add(c);

        }

        public void Printdecks()
        {
            
                for (int i = 0; i < deck.Count; i++) 
                {
                    deck[i].print();
                }
            
        }
        public void Printdiscard()
        {
            
                for (int i = 0; i < discard.Count; i++) 
                {
                    discard[i].print();
                }
            
        }
            
      
    }

}