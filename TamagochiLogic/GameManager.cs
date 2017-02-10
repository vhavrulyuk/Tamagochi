using System;
using System.Diagnostics;
using System.ServiceModel.Channels;
using System.Threading;
using System.Windows.Threading;
using TamagochiLogic;

public class GameManager {

    // Attributes and properties
    private double secondsBetweenSounds = 9;
    private ITamagochi _tamagochi = null;
    private int points;
    private DispatcherTimer timer = null;

    private static GameManager _instance = null;

    public static GameManager Instance
    {
        get
        {
            if ( _instance == null )
                _instance = new GameManager();
            return _instance;
        }
    }

    public ITamagochi Tamagochi { get { return _tamagochi; } }

    private GameManager()
    {
        timer = new DispatcherTimer();
        timer.Stop();
        
    }

    public void CreateTamagochi(TamagochiType type, string name)
    {
        if (_tamagochi == null)
        {
            _tamagochi = TamagochiCreator.CreateTamagochi(type);
            _tamagochi.Name = name;
            Debug.WriteLine(_tamagochi.Name);
            timer.Tick += ProduceSound_Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(secondsBetweenSounds);
            timer.Start();
            Debug.WriteLine(_tamagochi.Health);
            Debug.WriteLine(_tamagochi.GetType().ToString());
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void RestoreTamagochi(GameState memento)
    {
        _tamagochi = TamagochiRestorer.RestoreTamagochi(memento);
    }



    private void ProduceSound_Timer_Tick(object sender, EventArgs e)
    {
        _tamagochi.ProduceSound();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    // Operation
    // return GameState
    public GameState getGameState ()
    {
    throw new System.Exception ("Not implemented yet!");
    }
    // Operation
    // param state
    public void loadGame (GameState state)
    {
    }
}

