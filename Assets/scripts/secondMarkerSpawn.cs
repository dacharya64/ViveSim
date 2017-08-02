using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondMarkerSpawn : MonoBehaviour {

/*
 * Places second marker at the position in each trial that the CSV gives it 
 */

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = ParseCSV.secondMarkerPosition;
    }
}
