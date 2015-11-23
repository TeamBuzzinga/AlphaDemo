using UnityEngine;
using System.Collections;

public class CameraController_New : MonoBehaviour {

	public Transform target;
	public float lookSmooth = 0.09f;
	public Vector3 offsetFromTarget = new Vector3(0, 6, -8);
	public float xTilt = 10;

	Vector3 destination = Vector3.zero;
	CharacterController_New charController;
	float rotateVel = 0;

	void Start() {
		SetCameraTarget (target);
	}

	void SetCameraTarget(Transform t) {
		target = t;
		if (target != null) {
			if (target.GetComponent<CharacterController_New>()) {
				charController = target.GetComponent<CharacterController_New>();
			} else {
				Debug.LogError("The camera's target needs a character controller.");
			} 
		} else {
			Debug.LogError("Target is missing for the camera.");
		}
	}

	void LateUpdate() {
		//moving
		MoveToTarget ();
		//rotating
		LookAtTarget ();

	}

	void MoveToTarget(){//moving the camera behind the target
		destination = charController.TargetRotation * offsetFromTarget;
		destination += target.position;
		transform.position = destination;
	}

	void LookAtTarget() {
		float eulerYAngle = Mathf.SmoothDampAngle (transform.eulerAngles.y, target.eulerAngles.y, ref rotateVel, lookSmooth);
		transform.rotation = Quaternion.Euler (transform.eulerAngles.x, eulerYAngle, 0);
	}
}
