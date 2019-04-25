using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacements : MonoBehaviour {


    private Rigidbody rb;
    public float speed;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //j'ai copié collé mon vieil exemple de roll-a-ball, on comprendra plus tard
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }


}
