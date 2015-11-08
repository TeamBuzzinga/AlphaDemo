using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {
    public float maxTime;

    float gameTimer;
    bool gameEnded;
    
    void Update()
    {
        updateTimer();
        if (checkPlayerTimeEnded())
        {

        }
    }

    void updateTimer()
    {
        gameTimer = Mathf.MoveTowards(gameTimer, 0, Time.deltaTime);
    }

    bool checkPlayerTimeEnded()
    {
        return false;
    }

    public float getGameTimer()
    {
        return gameTimer;
    }

}
