using System;
using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class TubarãoMartelo : Animal, IBranquiado {
        public string  RespirarDebaixoDAgua() {
            return this.GetType ().Name + "Usa a cabeça de Martelo pra se proteger.";
        }
    }
}