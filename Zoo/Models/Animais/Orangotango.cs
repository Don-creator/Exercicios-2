using System;
using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Orangotango : Animal, IArboricula {
        public string EscalarArvores () {
            return this.GetType ().Name + "Entrou na Casa da Arvore";
        }
    }
}