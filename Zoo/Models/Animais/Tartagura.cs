using System;
using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Tartaruga : Animal, ITerrestre {
        public string  Andar() {
            return this.GetType ().Name + "Usa seu Casco para se proteger.";
        }
    }
}