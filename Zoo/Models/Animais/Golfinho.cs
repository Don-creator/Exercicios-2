using System;
using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Golfinho : IAquatico 
    {
        public string Nadar() {
            return this.GetType ().Name + "Nada muito rapido.";
        }
    }
}