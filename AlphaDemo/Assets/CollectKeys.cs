using UnityEngine;
using System.Collections;

public class CollectKeys : MonoBehaviour {
    public GameLogic gameLogic;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            gameLogic.collectKey(true);
            Destroy(this.gameObject);
        }
    }
}
