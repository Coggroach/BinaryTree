using System;
using System.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            using(var reader = File.OpenText("Cards.txt"))
            {
                var line = "";
                var hasName = false;
                var name = "";
                var hasCardId = false;
                var cardId = "";
                while( (line = reader.ReadLine()) != null )
                {
                    if(line.StartsWith("Name:"))
                    {
                        name = line.Replace("Name:", "");
                        hasName = true;
                    }
                    if(line.StartsWith("CardId:"))
                    {
                        cardId = line.Replace("CardId:", "");
                        hasCardId = true;
                    }
                    if(hasCardId && hasName)
                    {
                        hasCardId = false;
                        hasName = false;
                        tree.Add(new Leaf(new Card(cardId, name)));
                    }
                }           
            }
            tree.Search("Placeholder Card").Card.Write();
            tree.Write();
            tree.Search("Activate Magmatron").Card.Write();
            tree.Write();
            tree.Search("Swipe").Card.Write();
            tree.Write();
            tree.Search("Savage Roar").Card.Write();
            tree.Write();
            var card = tree.Search("PoopCard");

            if (card != null)
                card.Card.Write();

            //tree.InOrder();
            var input = Console.ReadLine();
        }
    }
}
