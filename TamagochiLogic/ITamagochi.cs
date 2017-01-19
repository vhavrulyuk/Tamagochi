using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiLogic
{
    public interface ITamagochi
    {
        string Name { get; set; }
        void Play(TamagochiGame game);
        void Teach();
        void Eat(SolidFood food);
        void Drink(LiquidFood drink);
        void Cure(Medicine medicine);
        void ProduceSound();
        TamagochiState GetState();
        void Update(long time);
    }
}
