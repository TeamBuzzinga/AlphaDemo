using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {
    public float maxTime = 300;
    public int keysNeeded = 1;
    public GameOverManager gManager;

    float gameTimer;
    bool gameEnded;
    int keysCollected;
    
    void Start()
    {
        gameTimer = maxTime;
    }

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
        if (gameTimer <= 0)
        {
            gManager.triggerLoseGame();
        }
    }

    bool checkPlayerTimeEnded()
    {
        return gameTimer <= 0;
    }

    public float getGameTimer()
    {
        return gameTimer;
    }

    public void collectKey(bool collectedKey)
    {
        if (collectedKey)
        {
            keysCollected++;
        }
    }

    public bool hasKeys()
    {
        return keysCollected >= keysNeeded;
    }

    //true if player has won the game. false if they have lost
    public void triggerPlayerWin(bool playerWin)
    {

    }

}
