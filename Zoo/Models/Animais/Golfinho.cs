using System;
using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Golfinho : Animal, IAquatico
    {
        public string Nadar() {
            return this.GetType ().Name + "Nada muito rapido.";
        }
    }
}