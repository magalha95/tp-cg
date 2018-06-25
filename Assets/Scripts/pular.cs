using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pular : MonoBehaviour {
	public bool onGround;
	private Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();		
	}
	
	// Update is called once per frame
	void Update () {
		if(onGround) {
			if(Input.GetButtonDown("Jump")) {
				Vector3 movement = new Vector3(0f, 250.0f, 0f);
		
				rb.AddForce(movement * speed * Time.deltaTime);

				onGround = false;
			}
		}
	}
	
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Plane")) {
			onGround = true;
		}
	}

}
