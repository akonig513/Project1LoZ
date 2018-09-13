using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputToAnimator : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("horizontal_input", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("vertical_input", Input.GetAxisRaw("Vertical"));

        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            anim.speed = 0.0f;
        }
        else{
            anim.speed = 1.0f;
        }
    }
}
