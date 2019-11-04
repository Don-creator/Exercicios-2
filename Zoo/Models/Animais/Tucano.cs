using System;
using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Tucano : Animal, IVoador {
        public string  Voar() {
            return this.GetType ().Name + "Usa as Asas pra voar.";
        }
    }
}