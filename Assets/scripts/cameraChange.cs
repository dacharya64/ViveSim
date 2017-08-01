using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            orth.enabled = true;
            persp.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            orth.enabled = false;
            persp.enabled = true;
        }
    }
}
