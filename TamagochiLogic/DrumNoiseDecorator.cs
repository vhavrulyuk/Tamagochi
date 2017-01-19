using System;

namespace TamagochiLogic
{

    internal class DrumNoiseDecorator : TamagochiDecorator
    {
        public DrumNoiseDecorator(ITamagochi tamagochi) : base(tamagochi)
        {
            
        }

        // Attributes and properties
        public override void ProduceSound()
        {
            throw new System.Exception("Not implemented yet!");
        }

    }
}
