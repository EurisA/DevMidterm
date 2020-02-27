using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps : MonoBehaviour
{
    public Rigidbody myBODY;
    public Camera lookingMan;
    public float speedy;
    
    // Start is called before the first frame update
    void Start()
    {
        myBODY = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        lookingMan.transform.Rotate(0, MouseX, 0);
        lookingMan.transform.Rotate(-MouseY, 0, 0);
        Vector3 rotationz = lookingMan.transform.eulerAngles;
        rotationz.z = 0;
        lookingMan.transform.eulerAngles = rotationz;
    }
    
    void FixedUpdate()
    {
        if (myBODY.velocity.magnitude < 4)
        {
            myBODY.AddForce(lookingMan.transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * speedy, ForceMode.Impulse);
            myBODY.AddForce(lookingMan.transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * speedy, ForceMode.Impulse);
        }

    }
}
