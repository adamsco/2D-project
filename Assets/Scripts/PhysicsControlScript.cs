using UnityEngine;
using System.Collections;

public class PhysicsControlScript : MonoBehaviour {

	// Use this for initialization
	public float speed;

	private Rigidbody2D rBody;
	void Start () {

		rBody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			rBody.AddForce(Vector3.up * speed);
		}
		if (Input.GetKey("down")) {
			rBody.AddForce(-Vector3.up * speed);
		}
		if (Input.GetKey("left")) {
			rBody.AddForce(Vector3.left * speed);
		}
		if (Input.GetKey("right")) {
			rBody.AddForce(Vector3.right * speed);
		}
		
	}
}
