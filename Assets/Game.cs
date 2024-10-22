using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    private static Game instance;
    public static Game Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Game();
            }
            return instance;
        }
    }

    public void Initialize()
    {

    }

    public void GameOver()
    {

    }
}
