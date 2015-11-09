using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDScript : MonoBehaviour {
    public Text timerText;
    public Image keyImage;
    public GameLogic gameLogic;

    void Update()
    {
        int min = (int)(gameLogic.getGameTimer() / 60f);
        int seconds = (int)(gameLogic.getGameTimer() - min * 60);
        string time = min.ToString("00") + ":" + seconds.ToString("00");
        timerText.text = time;
        keyImage.enabled = gameLogic.hasKeys();
    }
}
