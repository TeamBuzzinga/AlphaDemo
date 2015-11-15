using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	
	public void startGame(string startScene){
		Application.LoadLevel (startScene);
	}
}
