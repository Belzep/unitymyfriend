using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {
	private Player player;
	// Use this for initialization
	void Start () {
		player = gameObject.GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
//		if (other.gameObject==player.gameObject) {
//			Debug.Log ("hello");
//		}

	}
}
