using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			transform.Translate(Vector3.forward * speed);
		}
		if (Input.GetKey("down")) {
			transform.Translate(-Vector3.forward * speed);
		}
		if (Input.GetKey("left")) {
			transform.Translate(Vector3.left * speed);
		}
		if (Input.GetKey("right")) {
			transform.Translate(Vector3.right * speed);
		}
	
	}
}
