using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerMovement : MonoBehaviour {

    public float movementSpeed;

	void Start () {
		
	}
	
	void Update () {
        Movement();
	}

    void Movement()
    {
        this.GetComponent<Rigidbody2D>().AddForce((new Vector2(Input.GetAxis("Horizontal"), 0)), ForceMode2D.Impulse);
        
        //this.transform.position = Input.GetAxis("Horizontal");
    }
}
