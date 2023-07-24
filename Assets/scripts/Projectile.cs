using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    // Start is called before the first frame update
    
    [SerializeField]
    private float speed = 10.0f;

	public GameObject player;

    void Start()
    {
        Instantiate(projectilePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(projectilePrefab, player.transform.position, player.transform.rotation);
 
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }
    } 
}
