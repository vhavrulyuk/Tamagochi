using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiLogic
{
    internal class TamagochiRestorer
    {
        public static ITamagochi RestoreTamagochi(GameState memento)
        {
            ITamagochi tamagochi;
            switch (memento.TamagochiState.TamagochiType)
            {
                case "TamagochiLogic.Cat":
                    tamagochi = new Cat();
                    break;
                case "TamagochiLogic.Dog":
                    tamagochi = new Dog();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Initialize(tamagochi, memento);
            return tamagochi;
        }

        static void Initialize(ITamagochi tamagochi, GameState memento)
        {
            tamagochi.Health = memento.TamagochiState.Health;
            tamagochi.Age = memento.TamagochiState.Age;
            tamagochi.Bellyful = memento.TamagochiState.Bellyful;
            tamagochi.Hapiness = memento.TamagochiState.Hapiness;
            tamagochi.Intellect = memento.TamagochiState.Intellect;
            tamagochi.Water = memento.TamagochiState.Water;
            tamagochi.Name = memento.TamagochiState.Name;
        }

    }
}
