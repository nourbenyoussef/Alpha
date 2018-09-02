using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathcoondition : MonoBehaviour {
	public bool isDead;
	 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)){
			isDead=false;


		}
		if (isDead){
			



			//GetComponent<PlayerMovementController>().SetActive(false);
		}
	}

	void OnColliderEnter2D(Collision2D col){
		if (col.gameObject.tag == "obstacle"){
			isDead = true;
		}
	}
}
