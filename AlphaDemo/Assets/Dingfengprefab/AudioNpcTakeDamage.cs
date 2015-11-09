using UnityEngine;
using System.Collections;
using RAIN.Core;
using RAIN.Action;

public class AudioNpcTakeDamage : MonoBehaviour {

	private AIRig npc;
	private GameObject player;
	// Use this for initialization
	void Start () {
		npc = GetComponentInChildren<AIRig>();
	}

	public void takeDamage() {
		if (npc.AI.Mind.AI.WorkingMemory.ItemExists ("stun") ) {
			Debug.Log("stunstun");
			npc.AI.Mind.AI.WorkingMemory.SetItem<bool>("stun",true);
			}
		}
}
