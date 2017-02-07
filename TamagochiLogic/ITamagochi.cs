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
        int Health { get; set; }
        int Bellyful { get; set; }
        int Intellect { get; set; }
        int Hapiness { get; set; }
        int Water { get; set; }
        long Age { get; set; }



        void Play(TamagochiGame game);
        void Teach();
        void Eat(SolidFood food);
        void Drink(LiquidFood drink);
        void Cure(Medicine medicine);
        void ProduceSound();
        //SaveMemento();
        TamagochiState Save();
        //RestoreMemento(TamagochiState tamagochiState);
        void Load(TamagochiState tamagochiState);
        void Update(long time);
    }
}
