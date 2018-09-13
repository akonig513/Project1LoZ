using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyMovement : MonoBehaviour {

    Rigidbody rb;
    public float move_speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 current_input = GetInput();
        rb.velocity = current_input * move_speed;
	}

    Vector2 GetInput(){
        float horiz_input = Input.GetAxisRaw("Horizontal");
        float vertical_input = Input.GetAxisRaw("Vertical");
        if(Mathf.Abs(horiz_input) > 0.0f){
            vertical_input = 0;
        }
        return new Vector2(horiz_input, vertical_input);
    }
}
