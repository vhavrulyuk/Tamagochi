using System;
using System.Windows;
using System.Windows.Media;

namespace TamagochiLogic
{
    internal abstract class Tamagochi : ITamagochi
    {
        /*protected int _bellyful;
        protected int _intellect;
        protected int _health;
        protected int _water;
        protected string _name;
        protected long _age;*/
        protected MediaPlayer mp;

        public string Name { get; set; }
        public int Health { get; set; }
        public int Bellyful { get; set; }
        public int Intellect { get; set; }
        public int Hapiness { get; set; }
        public int Water { get; set; }
        public long Age { get; set; }

        public virtual void Play(TamagochiGame game)
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // return 
        public virtual void Teach()
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // param food
        // return 
        public virtual void Eat(SolidFood food)
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // param drink
        // return 
        public virtual void Drink(LiquidFood drink)
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // param medicine
        // return 
        public virtual void Cure(Medicine medicine)
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        public abstract void ProduceSound();
        //Save Tamagochi state
        public TamagochiState Save()
        {
            MessageBox.Show("Saving Tamagochi state...");
            return new TamagochiState(Bellyful, Intellect, Hapiness, Health, Water, Name, Age);
        }
        //Restore Tamagochi State
        public void Load(TamagochiState tamagochiState)
        {
            MessageBox.Show("Restoring Tamagochi state...");
            Bellyful = tamagochiState.Bellyful;
            Intellect = tamagochiState.Intellect;
            Hapiness = tamagochiState.Hapiness;
            Health = tamagochiState.Health;
            Water = tamagochiState.Water;
            Name = tamagochiState.Name;
            Age = tamagochiState.Age;
        }

        // return TamagochiState
        // param time
        public virtual void Update(long time)
        {
            throw new System.Exception("Not implemented yet!");
        }



    }
}