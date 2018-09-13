using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

    public AudioClip rupee_sound_collection_clip;
    Inventory inventory;

	// Use this for initialization
	void Start () {
        inventory = GetComponent<Inventory>();
        if(inventory == null){
            Debug.LogWarning("WARNING: No Inventory Component");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider coll){
        GameObject object_collided_with = coll.gameObject;
        if(object_collided_with.tag == "Rupee"){
            if(inventory != null){
                inventory.AddRupee(1);
            }
            Debug.Log("Collected Rupee");
            Destroy(object_collided_with);

            AudioSource.PlayClipAtPoint(rupee_sound_collection_clip, Camera.main.transform.position);
        }
    }
}
