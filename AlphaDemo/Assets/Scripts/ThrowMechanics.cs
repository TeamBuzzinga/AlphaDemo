using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThrowMechanics : MonoBehaviour {
    public GameObject projectile;
    public Vector3 throwDirection;
    public Transform throwPosition;
    public float throwForce;
    public float throwTime;//The time that it takes to complete one throw
    public float coolDownTime;//The time before you can throw another ball
	public static int numberOfBalls = 3;//Amount of balls left to throw

    float throwTimer;
    float coolDownTimer;

	private Animator anim;

	void Start()
	{
		anim = this.GetComponent<Animator>();
	}

    void Update()
    {
        updateTimers();
        if (Input.GetButtonDown("Fire1"))
        {
			if(numberOfBalls > 0){
            	throwBall(true);
				numberOfBalls --;
			}
        }
    }



    void updateTimers()
    {
        throwTimer -= Time.deltaTime;
        coolDownTimer -= Time.deltaTime;

        if (throwTimer < 0)
        {
            throwTimer = 0;
        }

        if (coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }
    }

//    void createBall()
//    {
//        GameObject obj = (GameObject)Instantiate(projectile, throwPosition.position, new Quaternion());
//        Vector3 direction = new Vector3(transform.forward.x, 0, transform.forward.z).normalized;
//
//
//        obj.GetComponent<Rigidbody>().AddForce(direction * throwForce);
//		
//    }
//
	IEnumerator createBall()
	{
		yield return new WaitForSeconds (3f);
		GameObject obj = (GameObject)Instantiate(projectile, throwPosition.position, new Quaternion());
		Vector3 direction = new Vector3(transform.forward.x, 0, transform.forward.z).normalized;
		
		
		obj.GetComponent<Rigidbody>().AddForce(direction * throwForce);
		
	}

	public void throwBall(bool throwButtonDown) 
    {
        if (throwButtonDown && canThrow())
        {
            throwTimer = throwTime;
            coolDownTimer = coolDownTime;
			StartCoroutine("createBall");
            //createBall();
			anim.SetTrigger("Throw");

		}
    }

    public bool getIsThrowing()
    {

        return throwTimer > 0;
    }

    public bool canThrow()
    {
        return coolDownTimer <= 0;
    }
}
