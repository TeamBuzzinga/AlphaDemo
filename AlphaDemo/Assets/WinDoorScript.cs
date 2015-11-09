using UnityEngine;
using System.Collections;

public class WinDoorScript : MonoBehaviour {
    public GameOverManager gManager;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            gManager.triggerWinGame();
        }
    }
}
