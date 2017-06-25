using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllPlayer : MonoBehaviour
{
    
      public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
      
        translation *= Time.deltaTime;
       
        transform.Translate(0, 0, translation);
        
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    }
}
