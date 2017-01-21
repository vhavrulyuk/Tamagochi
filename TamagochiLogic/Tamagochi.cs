using System;
using System.Windows.Media;

namespace TamagochiLogic
{
    internal abstract class Tamagochi : ITamagochi
    {

        // Attributes and properties
        protected int bellyful;
        protected int intellect;
        protected int hapiness;
        protected int health;
        protected int water;
        protected string name;
        protected long age;
        protected MediaPlayer mp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // Operation
        // param game
        // return 
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
        

// Operation
// return TamagochiState
        public abstract TamagochiState GetState();
        // Operation
        // param time
        public virtual void Update(long time)
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // return int
        public virtual int GetBellyful()
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // return int
        public virtual int GetIntelect()
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // return int
        public virtual int GetHapiness()
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // return int
        public virtual int GetHealth()
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // return int
        public virtual int GetWater()
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // return long
        public virtual long GetAge()
        {
            throw new System.Exception("Not implemented yet!");
        }

        // Operation
        // param age
        public virtual void SetAge(long ageUpdate)
        {
        }

    }
}