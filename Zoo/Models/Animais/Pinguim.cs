using System;
using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Pinguim : Animal, IQuionofilo {
        public string  ResistirAoFrio() {
            return this.GetType ().Name + "Resistente a Agua Gelada.";
        }
    }
}