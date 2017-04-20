using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    Vector3 deltaPos;
    //public Transform player;
    public Rigidbody playerBody;
    public float speedMultiplier;



	void Start ()
    {
        //deltaPos = Vector3.zero;

	}
	
	
	void Update ()
    {
        //Debug.Log( Input.GetKey(KeyCode.DownArrow) );
        //Debug.Log(Input.GetAxis("Vertical") );

        //transform.position += deltaPos;
        // igivea rac transform.position = transform.position + deltaPos;

        deltaPos.x = Input.GetAxis("Horizontal");
        deltaPos.z = Input.GetAxis("Vertical");

        




    }
    void FixedUpdate ()
    {
        //playerBody.position = playerBody.position + deltaPos;
        playerBody.AddForce(deltaPos * speedMultiplier);
    }

}
