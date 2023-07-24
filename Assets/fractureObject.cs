using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fractureObject : MonoBehaviour
{
    public GameObject originalObject;
    public GameObject fracturedObject;
    public GameObject explosionVFX;
    public float explosionMinForce = 5; // Corrected variable name
    public float explosionMaxForce = 100; // Corrected variable name
    public float explosionForceRadius = 10;
    public float fragScaleFactor = 1;
    private GameObject fractObj;
    private GameObject exploVFX; // Added exploVFX variable

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) // Corrected "GetKeyDown" method call
        {
            Explode();
        }
        if (Input.GetKeyDown(KeyCode.R)) // Corrected "GetKeyDown" method call
        {
            Reset();
        }
    }

    void Explode()
    {
        if (originalObject != null)
        {
            originalObject.SetActive(false);
            if (fracturedObject != null)
            {
                fractObj = Instantiate(fracturedObject, originalObject.transform.position, Quaternion.identity) as GameObject; // Corrected object instantiation
                foreach (Transform t in fractObj.transform)
                {
                    var rb = t.GetComponent<Rigidbody>(); // Corrected variable name
                    if (rb != null)
                    {
                        rb.AddExplosionForce(Random.Range(explosionMinForce, explosionMaxForce), originalObject.transform.position, explosionForceRadius);
                    }

                    StartCoroutine(Shrink(t, 2));
                }

                Destroy(fractObj, 5);

                if (explosionVFX != null)
                {
                    exploVFX = Instantiate(explosionVFX, originalObject.transform.position, Quaternion.identity) as GameObject; // Corrected object instantiation
                    Destroy(exploVFX, 7);
                }
            }
        }
    }

    void Reset()
    {
        Destroy(exploVFX, 7);

        Destroy(fractObj);
        originalObject.SetActive(true);
    }

    IEnumerator Shrink(Transform t, float delay)
    {
        yield return new WaitForSeconds(delay);

        Vector3 newScale = t.localScale; // Corrected variable name "localscale" to "localScale"
        while (newScale.x >= 0)
        {
            newScale -= new Vector3(fragScaleFactor, fragScaleFactor, fragScaleFactor);

            t.localScale = newScale;
            yield return new WaitForSeconds(0.1f); // Corrected "Wait Seconds" to "WaitForSeconds"
        }
    }
}
