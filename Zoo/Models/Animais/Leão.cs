using System;
using Zoo.Interfaces;

namespace Zoo.Models.Animais {
    public class Leão {
        public string Andar() {
            return this.GetType ().Name + "Rei do Zoologico.";
        }
    }
}