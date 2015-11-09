using UnityEngine;
using System.Collections;
using RAIN.Core;
using RAIN.Action;

public class NpcTakeDamage : MonoBehaviour {

	private AIRig npc;
	private GameObject player;
	// Use this for initialization
	void Start () {
		npc = GetComponentInChildren<AIRig>();
	}

	public void takeDamage() {
		if (npc.AI.Mind.AI.WorkingMemory.ItemExists ("myHealth") && npc.AI.Mind.AI.WorkingMemory.ItemExists ("varCharClose")) {
			Debug.Log("Inside takeDamage");
			if (npc.AI.Mind.AI.WorkingMemory.GetItem<GameObject>("varCharClose") != null) {
				int myHealth = npc.AI.Mind.AI.WorkingMemory.GetItem<int>("myHealth");
				myHealth = myHealth - 10;
				npc.AI.Mind.AI.WorkingMemory.SetItem<int>("myHealth",myHealth);
			}
		}
	}
}
