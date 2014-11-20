using UnityEngine;
using System.Collections;

public class FrogJamp : MonoBehaviour {

	Animator animator;
	public float speed = 25;
	public float forwardSpeed = 50;
	bool didFlap = false;

	bool death = false;
	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//
		if (death)
						return;
		if (Input.GetKey (KeyCode.Space)) {
			forwardSpeed += Time.deltaTime*speed;
			
		}

		if(Input.GetKeyUp(KeyCode.Space)){
			animator.SetTrigger("doJamp");
			rigidbody2D.AddForce(Vector2.right*forwardSpeed);
			rigidbody2D.AddForce(Vector2.up*forwardSpeed*2);
			didFlap = true;
		}

		if(didFlap == true){
			forwardSpeed = 50;
			didFlap = false;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		animator.SetTrigger("die");
	}
}
