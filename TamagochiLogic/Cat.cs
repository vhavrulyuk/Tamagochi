using System;
using System.Diagnostics;
using System.Windows.Media;

namespace TamagochiLogic
{
    internal class Cat : Tamagochi
    {
        private string pathToMaoSounFile = @".\Audio\CatSounds\mao.mp3";


        // Operation
        public override void ProduceSound()
        {
            mp = new MediaPlayer();
            Uri maoSoundFile =
                new Uri(pathToMaoSounFile, UriKind.Relative);
            mp.Open(maoSoundFile);
            Debug.WriteLine("Playing standard Cat's sound");
            mp.Play();
            
        }

        public override TamagochiState GetState()
        {
            throw new System.Exception("Not implemented yet!");
        }

    }
}

