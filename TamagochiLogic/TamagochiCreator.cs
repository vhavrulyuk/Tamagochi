using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiLogic
{
    internal class TamagochiCreator
    {
        public static ITamagochi CreateTamagochi(TamagochiType type)
        {
            ITamagochi tamagochi;
            switch (type)
            {
                case TamagochiType.Cat:
                    tamagochi = new Cat();
                    break;
                case TamagochiType.Dog:
                    tamagochi = new Dog();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Initialize(tamagochi);
            return tamagochi;
        }

        static void Initialize(ITamagochi tamagochi)
        {
            tamagochi.Health = 100;
        }

    }
}
