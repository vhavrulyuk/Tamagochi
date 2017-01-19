using System;

namespace TamagochiLogic
{
    internal class LaughingDogDecorator : TamagochiDecorator
    {
        public LaughingDogDecorator(Tamagochi tamagochi) : base(tamagochi)
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
