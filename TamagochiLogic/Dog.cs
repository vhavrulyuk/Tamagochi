using System;
using System.Diagnostics;

namespace TamagochiLogic
{
    internal class Dog : Tamagochi
    {

        // Operation
        public override void ProduceSound()
        {
            Debug.WriteLine("Playing standard Dog's sound");
        }

        //public override TamagochiState GetState()
        //{
        //    throw new System.Exception("Not implemented yet!");
        //}

    }
}

