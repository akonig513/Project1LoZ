using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    int rupee_count = 0;

    public void AddRupee(int num){
        rupee_count += num;
    }

    public int GetRupees(){
        return rupee_count;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
