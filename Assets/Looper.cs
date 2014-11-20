using UnityEngine;
using System.Collections;

public class Looper : MonoBehaviour {

	int numBGPanels = 6;
	
//	float pipeMax = 0.8430938f;
//	float pipeMin = -0.003243029f;

	float pipeMin = -0.2243029f;
	float pipeMax = 0.7430938f;

	void Start() {
		GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");
		
		foreach(GameObject pipe in pipes) {
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range(pipeMin, pipeMax);
			pipe.transform.position = pos;
			//du ma bon cho
		}
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("Triggered: " + collider.name);
		
		float widthOfBGObject = ((BoxCollider2D)collider).size.x;
		
		Vector3 pos = collider.transform.position;
		
		pos.x += widthOfBGObject * numBGPanels - widthOfBGObject/1.5f;
		
		if(collider.tag == "Pipe") {
			pos.y = Random.Range(pipeMin, pipeMax);
		}
		
		collider.transform.position = pos;
		
	}
}
