using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * PLaces start marker at the position in each trial that the CSV gives it 
 */

public class startMarkerSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = ParseCSV.startMarkerPositon;
    }
}
