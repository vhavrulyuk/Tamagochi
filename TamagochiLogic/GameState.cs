using System;
using Microsoft.Win32;
using TamagochiLogic;



//Memento
public class GameState {
    private int _points;
    private TamagochiState _tamagochiState;

    public TamagochiState TamagochiState {
        get { return _tamagochiState; }
        set {_tamagochiState = value; }
    }

    public int Points
    {
        get
        {
            return _points;
        }

        set
        {
            _points = value;
        }
    }

    public GameState(int points)
    {
        TamagochiState = GameManager.Instance.Tamagochi.Save();
        Points = points;
    }

    public GameState()
    {
        TamagochiState = new TamagochiState();
        Points = 0;
    }
}

