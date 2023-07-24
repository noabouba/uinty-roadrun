using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static pointsTextScript;

public class winningPointsScript : MonoBehaviour
{
    public Text winningPointsText;

    // Start is called before the first frame update
    void Start()
    {
        winningPointsText.text = "You got " + pointsTextScript.getPoints() + " points!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
