using Zoo.Interfaces;
namespace Zoo.Models.Animais {
    public class Arara : Animal, IVoador {
        public string  Voar()
        {
            return this.GetType ().Name + "Usa as Asas pra voar.";
        }
    }
}