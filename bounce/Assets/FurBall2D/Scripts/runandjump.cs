using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runandjump : MonoBehaviour {
	 public float speed = 150;
     public Rigidbody2D rb2d;

 
 void Update () {

         float h = Input.GetAxisRaw("Horizontal")*speed;
    
    GetComponent<Rigidbody2D>().velocity = new Vector2(h,0);
    

        
    }
         
         
    


}