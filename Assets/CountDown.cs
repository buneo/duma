using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	static float timeLeft = 6;
	static int score = 0;
	static int highScore = 0;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {

				}
		timeLeft -= Time.deltaTime;
		
		if (timeLeft <= 0.0f)
		{
			// End the level here.
			guiText.text = "You ran out of time";
		}
		else
		{
			guiText.text = "" + (int)timeLeft + "";
		}

	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			timeLeft =6;
		
	}
}
