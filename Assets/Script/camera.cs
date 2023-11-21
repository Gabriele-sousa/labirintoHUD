using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public bool travaMouse = true;
    public float velMouse = 2.0f;
    public float mouseX = 0f;
    public float mouseY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * velMouse;
        mouseY -= Input.GetAxis("Mouse Y") * velMouse;

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
