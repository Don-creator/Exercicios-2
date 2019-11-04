using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Chimpanzé : Animal, IArboricula
    {
        public string EscalarArvores () 
        {
            return this.GetType ().Name + "Escala as Arvores.";
        }
    }
}