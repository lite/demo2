using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo2 : MonoBehaviour {

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		if(GUILayout.Button("play")){
			animator.SetBool("run",true);
		}
	}

}
