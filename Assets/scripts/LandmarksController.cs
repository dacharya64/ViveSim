using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Makes landmarks appear / disappear depending on whether the CSV file detects a trial has landmarks
 */ 

public class LandmarksController : MonoBehaviour {
    GameObject landmarks;

	// Use this for initialization
	void Start () {
        landmarks = GameObject.Find("Landmarks");
	}
	
	// Update is called once per frame
	void Update () {
        landmarks.SetActive(ParseCSV.isLandmark);
	}
}
