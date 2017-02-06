using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D rb2d;
	private Animator anim;
	private float speed=25f;
	private float jump=150f;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate(){
		if (Mathf.Abs(Input.GetAxis ("Horizontal"))>0.1f) {
			anim.SetBool ("walk", true);
		} else {
			anim.SetBool ("walk", false);}
		float h = Input.GetAxis ("Horizontal");
	
		if (Input.GetAxis("Horizontal")>0.1f){
			transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
			rb2d.AddForce ((Vector2.right * speed) * h);
		}

		if (Input.GetAxis("Horizontal")<-0.1f){
			transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
			rb2d.AddForce ((Vector2.right * speed) * h);
		}

		if (Input.GetButtonDown("Jump")) {
			rb2d.AddForce (Vector2.up * jump);
		}
		//rb2d.AddForce ((Vector2.right * speed) * h);

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "spike") {
			Application.LoadLevel ("scene1");}
	}
}
	

