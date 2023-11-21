using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    public GameObject me;

    public float vel = 0.05f;
    public float dif;
    public bool travaMouse = true;
    public float velMouse = 2.0f;
    public float mouseX = 0f;
    public float checkX;
    public float checkY;
    public float vida;
    // Start is called before the first frame update
    void Start()
    {
        if (travaMouse == false){
            return;
        }
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        checkX = me.transform.position.x;
        checkY = me.transform.position.z;
        vida = 2.0f;

    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * velMouse;
        transform.eulerAngles = new Vector3(0, mouseX, 0);
        //frente e tras
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0, 0, vel);
        }else if (Input.GetKey(KeyCode.S)){
            transform.Translate(0, 0, -(vel));
        }
        //lados
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(vel, 0, 0);
        }else if (Input.GetKey(KeyCode.A)){
            transform.Translate(-(vel), 0, 0);
        }  
    }

}
