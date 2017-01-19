using System;
using System.Diagnostics;
using System.Windows.Media;

namespace TamagochiLogic
{
    internal class DrumNoiseDecorator : TamagochiDecorator
    {
        private string pathToMaoSounFile = @".\Audio\CatSounds\DrumNoiseDecorator\ ошка - ћ€уканье.mp3";
        // Operation
      public DrumNoiseDecorator(Tamagochi tamagochi) : base(tamagochi)
        {}
        // Attributes and properties
        public override void ProduceSound()
        {
            MediaPlayer mp = new MediaPlayer();
            Uri maoSoundFile =
                new Uri(pathToMaoSounFile, UriKind.Relative);
            mp.Open(maoSoundFile);
            mp.Volume = 1.0;
            Debug.WriteLine("Playing loud Cat's sound");
            mp.Play();
        }
    }
}
