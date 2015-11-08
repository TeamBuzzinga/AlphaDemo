using UnityEngine;
using RAIN.Core;

namespace CompleteProject
{
    public class GameOverManager : MonoBehaviour
    {
		
        Animator anim;                          // Reference to the animator component.

		public GameObject NPC1;
		public GameObject NPC2;
		public GameObject NPC3;


		private AIRig aiRig1 = null;
		private AIRig aiRig2 = null;
		private AIRig aiRig3 = null;

		float restartTimer;
		float restartDelay=5f;

        void Awake ()
        {
            // Set up the reference.
            anim = GetComponent <Animator> ();
			aiRig1 = NPC1.GetComponentInChildren<AIRig> ();
			aiRig2 = NPC2.GetComponentInChildren<AIRig> ();
			aiRig3 = NPC3.GetComponentInChildren<AIRig> ();

        }


        void Update ()
        {
			int catch1=aiRig1.AI.WorkingMemory.GetItem<int>("catch_time");
			int catch2=aiRig2.AI.WorkingMemory.GetItem<int>("catch_time");
			int catch3=aiRig3.AI.WorkingMemory.GetItem<int>("catch_time");



			if (catch1 > 2||catch2>2||catch3>0) {
				anim.SetTrigger ("GameOver");
				restartTimer+=Time.deltaTime;
				if(restartTimer>=restartDelay)
					Application.LoadLevel(Application.loadedLevel);
			}
        }
    }
}