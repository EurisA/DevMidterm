using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingRaycast : MonoBehaviour
{
    public float maxDist = 2f;

    public float roombaSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray roombaRay = new Ray(transform.position, transform.forward);
        
        Debug.DrawRay(roombaRay.origin, roombaRay.direction * maxDist, Color.green);

        if (Physics.Raycast(roombaRay, maxDist))
        {
            int randomNum = Random.Range(0, 100);
            if (randomNum > 50)
            {
                transform.Rotate(0, 90, 0);
            }

            if (randomNum >= 50)
            {
                transform.Rotate(0, -90, 0);
            }

        }             else
        {
            transform.Translate(0, 0, Time.deltaTime * roombaSpeed);
        }
        
        
    }
}
