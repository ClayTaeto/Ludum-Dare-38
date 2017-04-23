using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {
	private Animator anim; 
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			anim.SetTrigger ("canAttack");
		}
	}

	void OnCollisionEnter (Collision other){
		Debug.Log ("hit other");
		if (other.gameObject.tag == "Player")
			return;
		
		Destroy (other.gameObject);
	}
}
