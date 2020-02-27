using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public CharacterController charControl;
    public float speedControl = 3;
    public float rotationSpeed = 90;
    
    // Start is called before the first frame update
    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

            charControl.Move(transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * speedControl + Physics.gravity * 0.69f);
            charControl.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed , 0));

    }
}
