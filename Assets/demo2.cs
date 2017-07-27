using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo2 : MonoBehaviour {

	private Animator animator;
	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		animator.SetBool("run",true);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update");
		animator.SetBool("run",true);
	}

	void Awake(){
		Debug.Log ("Awake");
		animator = GetComponent<Animator> ();
		animator.SetBool("run",true);
	}

	void FixedUpdate(){
		Debug.Log ("FixedUpdate");
		animator.SetBool("run",true);
	}

	void LateUpdate(){
		Debug.Log ("LateUpdate");
		animator.SetBool("run",true);
	}
	void OnGUI(){
		Debug.Log ("Awake");
		animator.SetBool("run",true);
	}
	void OnDisable(){
		Debug.Log ("Awake");
	}

	void OnEnabled(){
		Debug.Log ("OnEnabled");
		animator.SetBool("run",true);
	}

}
