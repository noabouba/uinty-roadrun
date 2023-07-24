using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    // Start is called before the first frame update
    
    [SerializeField]
    private float speed = 10.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.position += Time.deltaTime * speed * transform.forward;
		if (transform.position.y < 0) {
               Destroy(gameObject); 
}

    } 
}
