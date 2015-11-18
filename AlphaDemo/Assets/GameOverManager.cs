using UnityEngine;
using RAIN.Core;
using UnityEngine.UI;

 public class GameOverManager : MonoBehaviour
    {
        public Text gameOverText;
		
        Animator anim;                          // Reference to the animator component.

		public GameObject NPC1;
		public GameObject NPC2;
		//public GameObject NPC3;


		private AIRig aiRig1 = null;
		private AIRig aiRig2 = null;
		//private AIRig aiRig3 = null;

		float restartTimer;
		float restartDelay=5f;

        void Awake ()
        {
            // Set up the reference.
            anim = GetComponent <Animator> ();
			aiRig1 = NPC1.GetComponentInChildren<AIRig> ();
			aiRig2 = NPC2.GetComponentInChildren<AIRig> ();
			//aiRig3 = NPC3.GetComponentInChildren<AIRig> ();

        }


        void Update ()
        {
			int catch1=aiRig1.AI.WorkingMemory.GetItem<int>("catch_time");
			int catch2=aiRig2.AI.WorkingMemory.GetItem<int>("catch_time");
			//int catch3=aiRig3.AI.WorkingMemory.GetItem<int>("catch_time");



			if (catch1 + catch2 > 2) {
                restartTimer += Time.deltaTime;
                triggerLoseGame();
                if (restartTimer>=restartDelay){
					Application.LoadLevel(Application.loadedLevel);
					ThrowMechanics.numberOfBalls = 3;
				}
			}
        }

        public void triggerLoseGame()
        {
            
           
            anim.SetTrigger("GameOver");
            
        }

        public void triggerWinGame()
        {
            gameOverText.text = "You win";
            anim.SetTrigger("GameOver");
         }

        
     
}