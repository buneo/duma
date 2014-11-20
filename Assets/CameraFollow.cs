using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Transform player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Frog").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerpos = player.position;
		playerpos.z = transform.position.z;
		playerpos.y = transform.position.y;
		transform.position = playerpos;
	}
}
