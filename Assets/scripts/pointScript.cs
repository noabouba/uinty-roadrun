using System.Collections;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using static pointsTextScript;

public class pointScript : MonoBehaviour
{
    public GameObject SquareBox8;
    public GameObject RectBox;
    private bool isRan = false;

    // Start is called before the first frame update
    void Start()
    {
      SquareBox8.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
         
     private void OnTriggerEnter(Collider other)
     {
         if(this.tag == "finnishBox") {
            SquareBox8.SetActive(true);
            RectBox.SetActive(false);
            pointsTextScript.addPointsWhenBox();

         } else if(this.tag != "finnishBall") {
            
            if(other.tag == "bullet")
            {
               pointsTextScript.addPointsWhenBullet();
               Destroy(other);

               Destroy(gameObject); 
            }   
            if(other.tag == "Player") {
               pointsTextScript.addPoint();

               Destroy(gameObject);
            }        
        } else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
     }
}