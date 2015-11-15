using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {
    public Transform door1;
    public Transform door2;
    public Transform door1OpenPosition;
    public Transform door2OpenPosition;
    public GameLogic gameLogic;

	void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player" && gameLogic.hasKeys())
        {
            openDoors();
        }
    }

    void openDoors()
    {
        door1.position = door1OpenPosition.position;
        door2.position = door2OpenPosition.position;
    }
}
