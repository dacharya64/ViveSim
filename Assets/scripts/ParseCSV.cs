using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParseCSV : MonoBehaviour { 
    public TextAsset csv; //csv you're reading from, do not change 
    string[,] data; //a 2d string array of all of the data from the csv
    int count; //the current row #

    //for intitializing elements in game 
    public static Vector3 startMarkerPositon;
    public static Vector3 firstMarkerPosition;
    public static Vector3 secondMarkerPosition;
    public static Vector3 responsePosition;

    public static bool isLandmark;

    public static String participantNumber;
    public static String navNumber;


    // Use this for initialization
    void Start () {
        count = 1; //set it so it skips the descriptor row on initialization
        data = CSVReader.SplitCsvGrid(csv.text);   
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            getStartMarkerPosition();
            getFirstMarkerPosition();
            getSecondMarkerPosition();
            getResponsePosition();
            getLandmark();
            getParticipantNumber();
            getNavNumber();
            count++;
        }
    }



    private void getStartMarkerPosition()
    {
        //Debug.Log("X: " + float.Parse(data[2, count]) + ", Z: " + float.Parse(data[3, count]));
        startMarkerPositon = new Vector3(float.Parse(data[2, count]), 0, float.Parse(data[3, count]));
    }
    private void getFirstMarkerPosition()
    {
        firstMarkerPosition = new Vector3(float.Parse(data[4, count]), 0, float.Parse(data[5, count]));
    }
    private void getSecondMarkerPosition()
    {
        secondMarkerPosition = new Vector3(float.Parse(data[6, count]), 0, float.Parse(data[7, count]));
    }
    private void getResponsePosition()
    {
        responsePosition = new Vector3(float.Parse(data[9, count]), 0, float.Parse(data[10, count]));
    }
    private void getLandmark()
    {
        if (data[16, count].Equals("L"))
        {
            isLandmark = true;
        }
        else {
            isLandmark = false; 
        }
    }

    private void getParticipantNumber()
    {
        participantNumber = data[0, count];
    }

    private void getNavNumber()
    {
        navNumber = data[18, count];
    }
}
