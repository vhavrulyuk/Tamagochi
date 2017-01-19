using System;
using System.Threading;
using TamagochiLogic;

public class GameManager {

    // Attributes and properties
    private Tamagochi _tamagochi = null;
    private int points;
    private Timer timer = null;

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
    }

    public void CreateTamagochi(TamagochiType type, string name)
    {
        if (_tamagochi == null)
        {
            _tamagochi = TamagochiCreator.CreateTamagochi(type);
            _tamagochi.Name = name;
        }
        else
        {
            throw new InvalidOperationException();
        }
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

