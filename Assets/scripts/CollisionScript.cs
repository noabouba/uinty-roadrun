using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    [SerializeField]
    Text instructionsText;

    public string instructionsMsg = "For instructions - go into the glowing tomb";

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "glowing_tomb")
        {
            instructionsMsg = "Statue events: \nC - Stop motion\nO - Fall down\nM - Move to sides\nL - Rotate";
        }
    }

    // Start is called before the first frame update
    void Start()
    { 
        instructionsText = GameObject.Find("instructionsText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        instructionsText.text = instructionsMsg;
    }
}
