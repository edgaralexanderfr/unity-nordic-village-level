using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	public int speed = 100;
	public int rotationSpeed = 100;
	public int jumpForce = 100;

	private Rigidbody rigidBody;
	
	// Use this for initialization
	void Start () {
		this.rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			gameObject.transform.Translate(Vector3.forward * Time.deltaTime * this.speed);
		}

		if (Input.GetKey(KeyCode.S)) {
			gameObject.transform.Translate(Vector3.back * Time.deltaTime * this.speed);
		}

		if (Input.GetKey(KeyCode.A)) {
			gameObject.transform.Translate(Vector3.left * Time.deltaTime * this.speed);
		}

		if (Input.GetKey(KeyCode.D)) {
			gameObject.transform.Translate(Vector3.right * Time.deltaTime * this.speed);
		}

		if (Input.GetKey(KeyCode.J)) {
			gameObject.transform.Rotate(Vector3.down * Time.deltaTime * this.rotationSpeed);
		}

		if (Input.GetKey(KeyCode.L)) {
			gameObject.transform.Rotate(Vector3.up * Time.deltaTime * this.rotationSpeed);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			this.rigidBody.AddForce(Vector3.up * this.jumpForce);
		}
	}
}
