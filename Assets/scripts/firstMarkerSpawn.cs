using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * PLaces first marker at the position in each trial that the CSV gives it 
 */

public class firstMarkerSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = ParseCSV.firstMarkerPosition;
    }
}
