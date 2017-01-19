using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiLogic
{
    internal class TamagochiCreator
    {
        public static Tamagochi CreateTamagochi(TamagochiType type)
        {
            switch (type)
            {
                case TamagochiType.Cat:
                    return new Cat();
                case TamagochiType.Dog:
                    return new Dog();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
