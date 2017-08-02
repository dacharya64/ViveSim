using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Handles changing the camera between orthographic and perspective view
 * by pressing 1 or 2, respectively
 */ 

public class cameraChange : MonoBehaviour {
    public Camera orth;
    public Camera persp;

	// Use this for initialization
	void Start () {
        orth.enabled = true;
        persp.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            orth.enabled = true;
            persp.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        { 
            orth.enabled = false;
            persp.enabled = true;
        }
    }
}
