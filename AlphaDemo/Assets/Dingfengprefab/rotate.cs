using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	// Use this for initialization
    Vector3 _rotate;
    public float speed=5;
	void Start () {
        _rotate = new Vector3(0,90,0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(_rotate * speed * Time.deltaTime);
	}
}
