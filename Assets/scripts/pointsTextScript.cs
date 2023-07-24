using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class pointsTextScript : MonoBehaviour
{
    public Text pointsText;
    
    private static int points = 0;

    public static void addPoint() {
        points++;
    }
    
    public static void addPointsWhenBullet() {
        points += 5;
    }
    
    public static void addPointsWhenBox() {
        points += 10;
    }
    
    public static int getPoints() {
        return points;
    }

    // Start is called before the first frame update
    void Start()
    {
         pointsText.text = "Points: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Points: " + points.ToString();
    }
    
}
