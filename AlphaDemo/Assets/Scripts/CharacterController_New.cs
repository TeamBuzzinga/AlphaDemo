using UnityEngine;
using System.Collections;

public class CharacterController_New : MonoBehaviour {

	public float inputDelay = 0.1f;
	public float forwardVel = 12;
	public float rotateVel = 100;

	Quaternion targetRotation;
	Rigidbody rBody;
	float forwardInput, turnInput;

	public Quaternion TargetRotation {
		get { return targetRotation; }
	}

	// Use this for initialization
	void Start () {
		targetRotation = transform.rotation;
		rBody = GetComponent<Rigidbody> ();
		forwardInput = turnInput = 0;
	
	}

	void GetInput() {
		forwardInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}

	void Turn () {
		targetRotation = Quaternion.AngleAxis (rotateVel * turnInput * Time.deltaTime, Vector3.up);
		transform.rotation = targetRotation;
	}
	
	// Update is called once per frame
	void Update () {
		GetInput ();
		Turn ();
	
	}
	void Run() {
		if (Mathf.Abs (forwardInput) > inputDelay) {
			rBody.velocity = transform.forward * forwardInput * forwardVel;
		} else {
			rBody.velocity = Vector3.zero;
		}
	}

	void FixedUpdate() {
		Run ();;
	}
}
