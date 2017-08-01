using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMarkerSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = ParseCSV.startMarkerPositon;
    }
}
