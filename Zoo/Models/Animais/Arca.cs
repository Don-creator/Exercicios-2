using System.Collections.Generic;
using Zoo.Models;


namespace Zoo.Models.Interfaces
{
    public class Arca
    {
        public static Dictionary<int, Animais> Animais = new Dictionary<int, Animais>(){
            {1, new Arara()},
            {2, new Chimpanzé()},
            {3, new Golfinho()},
            {4, new Leão()},
            {5, new Orangotango()},
            {6, new Pinguim()},
            {7, new Tartaruga()},
            {8, new TubaraoMartelo()},
            {9, new Tucano()}
        };
    }
}