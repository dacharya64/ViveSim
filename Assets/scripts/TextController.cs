using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    /*changes the UI text based on the data in the CSV file*/

    public Text participantText; // assign it from inspector
    public Text navText;
    
    

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        participantText.text = "Participant: " + ParseCSV.participantNumber;
        //depending on nav interface, update text
        if (ParseCSV.navNumber.Equals("0"))
        {
            navText.text = "Nav Interface: Concordant";
        }
        else if (ParseCSV.navNumber.Equals("1"))
        {
            navText.text = "Nav Interface: Partially Concordant";
        }
        else {
            navText.text = "Nav Interface: Discordant";
        }

        //navText.text = "Nav Interface: " + ParseCSV.navNumber;

    }
}
