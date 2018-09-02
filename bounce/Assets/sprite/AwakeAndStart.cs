using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour {
    void Awake()
    {
        Debug.Log("Awake called ");

    }

    
	// Use this for initialization
	void Start () {
        Debug.Log("Start called ");
    }
	
	// Update is called once per frame
	void Update ()
   {
        if (Input.GetButtonDown("Horizontal")){
          Debug.Log("space bar button was pressed");
        }

    }
}