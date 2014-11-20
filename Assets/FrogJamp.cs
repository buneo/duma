using UnityEngine;
using System.Collections;

public class FrogJamp : MonoBehaviour {
	
	public float speed = 25;
	public float forwardSpeed = 50;
	bool didFlap = false;
	
	Animator animator1;
	// Use this for initialization
	void Start () {
		animator1 = transform.GetComponentInChildren<Animator>();
	}

	// Update is called once per frame
	void Update () {
		Vector3 frog = new Vector3();
		frog = transform.position;
		
		if(frog.y <0.3f){
			Debug.Log("Die");
		}
		
		if (Input.GetKey (KeyCode.Space) && didFlap == false) {
			forwardSpeed += Time.deltaTime*speed;	
			if(forwardSpeed > 120){
				forwardSpeed = 120;
			}
		}
		

	}

	void FixedUpdate(){
		if (Input.GetKeyUp (KeyCode.Space) && didFlap == false) {
			animator1.SetTrigger ("doJumb");
			rigidbody2D.AddForce (Vector2.right * forwardSpeed);
			rigidbody2D.AddForce (Vector2.up * forwardSpeed * 2);
			didFlap = true;
		}


	}

	void OnCollisionEnter2D(Collision2D coll){
		if (didFlap == true) {
			forwardSpeed = 50;
			didFlap = false;
		}


	}
}
