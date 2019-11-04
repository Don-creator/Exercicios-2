using System;
using Zoo.Interfaces;

namespace Zoo.Models.Animais {
    public class Leão : Animal, ITerrestre {
        public string Andar() {
            return this.GetType ().Name + "Rei do Zoologico.";
        }
    }
}