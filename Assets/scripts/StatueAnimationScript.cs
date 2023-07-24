using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StatueAnimationScript : MonoBehaviour
{
    private Animator mAnimator;
    private bool collidingOpen = false;
    private bool collidingClose = false;
    private bool collidingMoveSide = false;
    private bool collidingRotate = false;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)) { 
            collidingOpen = true;
            mAnimator.SetTrigger("TrOpen");
        }

        if(Input.GetKeyDown(KeyCode.C)) {
            collidingClose = true;
            mAnimator.SetTrigger("TrClose");
        }
        
        if(Input.GetKeyDown(KeyCode.M))
        {
            collidingMoveSide = true;
            mAnimator.SetTrigger("TrMoveToSides");
        }
        
        if(Input.GetKeyDown(KeyCode.L)) {
            collidingRotate = true;
            mAnimator.SetTrigger("TrRotate");
        }

        if (collidingClose && collidingOpen && collidingMoveSide && collidingRotate)
        {
            SceneManager.LoadScene(3);            
        }
    }
}
