using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasCode : MonoBehaviour
{
    public float maxDist = 1000f;
    public GameObject paintbruh;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        Debug.DrawRay(camRay.origin, camRay.direction * maxDist, Color.cyan);

        RaycastHit hitObject;

        if (Physics.Raycast(camRay, out hitObject, maxDist))
        {
            paintbruh.transform.position = hitObject.point;
            if (Input.GetMouseButton(0))
            {
                GameObject paint = Instantiate(paintbruh, hitObject.point, Quaternion.identity);
                paint.transform.SetParent(hitObject.transform);
            }
        
            hitObject.transform.Rotate(new Vector3 (0, 0, 350 * Time.deltaTime));
        }
        
    }
}
