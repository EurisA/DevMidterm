using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public float maxDistance = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, Vector3.down);
        
        Debug.DrawRay(myRay.origin, myRay.direction * maxDistance, Color.magenta);

        if (Physics.Raycast(myRay, maxDistance))
        {
            Debug.Log("Hit ground");
        }
        else
        {
            transform.Rotate(0, 5f, 0);
        }
    }
}
