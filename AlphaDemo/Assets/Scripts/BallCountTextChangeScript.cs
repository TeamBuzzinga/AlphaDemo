using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallCountTextChangeScript : MonoBehaviour {

	private Text ballCountText;
	// Use this for initialization
	void Start () {
		ballCountText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		ballCountText.text = ThrowMechanics.numberOfBalls.ToString ();
	}
}
