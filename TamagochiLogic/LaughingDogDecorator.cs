using System;

namespace TamagochiLogic
{
    internal class LaughingDogDecorator : TamagochiDecorator
    {
        public LaughingDogDecorator(ITamagochi tamagochi) : base(tamagochi)
        {
        }
        // Operation
        public void produceSound()
        {
            // TODO: do some sound here
            //base.ProduceSound();
        }

    }
}
