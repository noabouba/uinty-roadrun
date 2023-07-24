using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera overheadCamera;
    public Camera overallCamera;
    
    public void ShowOverheadView() {
        overallCamera.enabled = false;
        overheadCamera.enabled = true;
    }
    
    public void ShowOverallView() {
        overallCamera.enabled = true;
        overheadCamera.enabled = false;
    }

    public void switchCameras(){
        overallCamera.enabled = !overallCamera.enabled;
        overheadCamera.enabled = !overheadCamera.enabled;
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowOverallView();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            switchCameras();
            Debug.Log("KEY");
        }
    }
}
