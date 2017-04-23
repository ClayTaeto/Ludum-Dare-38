using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour {
	/*
	public float speed = 1.5f;
	public float moveSpeed = 0.02f;
	private Vector3 pos;

	// Use this for initialization

	void Start () {
		//pos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		pos.x = 0;
		pos.z = 0;

		if (Input.GetKey("w") || Input.GetKey("up"))
			pos.z += moveSpeed;
		
		if (Input.GetKey("s") || Input.GetKey("down"))
			pos.z -= moveSpeed;
		if (Input.GetKey("a") || Input.GetKey("left"))
			pos.x -= moveSpeed;
		if (Input.GetKey("d") || Input.GetKey("right"))
			pos.x += moveSpeed;
			
		if (transform.position.z > -8.6 && pos.z > 0) {
			pos.z = 0;
		}

		if (transform.position.z < -11 && pos.z < 0) {
			pos.z = 0;
		}
			
		if (transform.position.x < -9.8)
			pos.x = 0;
		transform.position += pos;
	}

	*/

	public float speed = 6.0f;
	public float jumpSpeed = 8.0f;
	public float gravity = 20f;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	void Start () {
		controller = GetComponent<CharacterController> ();

	}
	void Update() {
		

		moveDirection = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;
		if (transform.position.z > -8.6 && moveDirection.z > 0) {
			moveDirection.z = 0;
		}

		if (transform.position.z < -11 && moveDirection.z < 0) {
			moveDirection.z = 0;
		}

		if (transform.position.x < -9.8)
			moveDirection.x = 0;

		//moveDirection.y -=gravity * Time.delt
		controller.Move(moveDirection * Time.deltaTime);


	}

}