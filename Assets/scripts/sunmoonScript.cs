using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunmoonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, 10 * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}