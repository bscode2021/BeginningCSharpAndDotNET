using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    public class CardCollection : CollectionBase, ICloneable
    {
        public object Clone()
        {
            CardCollection newCardCollection = new CardCollection();
            foreach (Card sourceCard in List)
            {
                newCardCollection.Add(sourceCard);
            }
            return newCardCollection;
        }

        public void Add(Card card) => List.Add(card);
        public void Remove(Card card) => List.Remove(card);

        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }

        /// <summary>
        /// Utility method for copying card instances into another CardCollection
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        /// 
        public void CopyTo(CardCollection targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }
        /// <summary>
        /// Check to see if the CardCollection collection contains a particular card.
        /// This calls the Contains() method of the ArrayList for the collection,
        /// which you access through the InnerList property.
        /// </summary>
        public bool Contains(Card card) => InnerList.Contains(card);

       
    }
}
