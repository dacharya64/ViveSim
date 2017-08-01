using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
