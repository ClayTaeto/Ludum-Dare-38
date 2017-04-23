using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class isGameOver : MonoBehaviour {
	private GameObject[] enemies;
	public float timeSinceCheck = 0;
	private float timeBetweenChecks = .600f;
	public GameObject[] ui;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceCheck += Time.deltaTime;
		if (timeSinceCheck > timeBetweenChecks) {
			timeSinceCheck = 0;
			enemies = GameObject.FindGameObjectsWithTag("Enemy");
			Debug.Log("Checking for Enemies");
			if (enemies.Length == 0) {
				Debug.Log ("No enemies");
				foreach (GameObject bit in ui) {
					bit.SetActive (true);
				}

			}
		}
	}
}
