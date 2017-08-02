using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Places answer reticle indicator the position in each trial that the CSV gives it 
 */

public class reticleSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = ParseCSV.responsePosition;
    }
}
