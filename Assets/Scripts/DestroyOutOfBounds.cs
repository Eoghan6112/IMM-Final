using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20;
    private float bottomBound = -15;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If projectile goes beyond topBound or bottomBound destroy it.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
