using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "DUDE")
        {
            camera1.gameObject.SetActive(false);
            camera2.gameObject.SetActive(true);
        }
    }
}
