using System;

namespace TamagochiLogic
{
    internal abstract class TamagochiDecorator : ITamagochi
    {

        // Attributes and properties
        protected ITamagochi tamagochi;

        public string Name
        {
            get { return tamagochi.Name; }
            set { tamagochi.Name = value; }
        }

        public TamagochiDecorator(ITamagochi tamagochi)
        {
            this.tamagochi = tamagochi;
        }

        // Operation
        // param game
        // return 
        public void Play(TamagochiGame game)
        {
            tamagochi?.Play(game);
        }

        // Operation
        // return 
        public void Teach()
        {
            tamagochi?.Teach();
        }

        // Operation
        // param food
        // return 
        public void Eat(SolidFood food)
        {
            tamagochi?.Eat(food);
        }

        // Operation
        // param drink
        // return 
        public virtual void Drink(LiquidFood drink)
        {
            tamagochi?.Drink(drink);
        }

        // Operation
        // param medicine
        // return 
        public virtual void Cure(Medicine medicine)
        {
            tamagochi?.Cure(medicine);
        }

        // Operation
        public virtual void ProduceSound()
        {
            tamagochi?.ProduceSound();
        }

        // Operation
        // return TamagochiState
        public virtual TamagochiState GetState()
        {
            return tamagochi.GetState();
        }

        // Operation
        // param time
        public virtual void Update(long time)
        {
            tamagochi?.Update(time);
        }
    }
}
