using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class radar : MonoBehaviour
{ 
    public GameObject sensor;
    public GameObject r;
    public GameObject g;
    public GameObject b;
    public GameObject y;
    public float dif;
    
    
    void Start()
    {
        r = GameObject.FindGameObjectWithTag("red");
        g = GameObject.FindGameObjectWithTag("green");
        b = GameObject.FindGameObjectWithTag("blue");
        y = GameObject.FindGameObjectWithTag("yellow");
        sensor = GameObject.FindGameObjectWithTag("radar");
    }

    void Update()
    {
        if(r.transform.position.x - sensor.transform.position.x < 8 && r.transform.position.z - sensor.transform.position.z < 8){
            dif = r.transform.position.x - sensor.transform.position.x;
            sensor.GetComponent<Image>().color = new Color(255, 0, 0 ); 

        }else if(g.transform.position.x - sensor.transform.position.x < 8 && g.transform.position.z - sensor.transform.position.z < 8){
            dif = r.transform.position.x - sensor.transform.position.x;
            sensor.GetComponent<Image>().color = new Color(0, 255, 0 ); 

        }else if(b.transform.position.x - sensor.transform.position.x < 8 && b.transform.position.z - sensor.transform.position.z < 8){
            dif = r.transform.position.x - sensor.transform.position.x;
            sensor.GetComponent<Image>().color = new Color(0, 0, 255); 

        }else if(y.transform.position.x - sensor.transform.position.x < 8 && y.transform.position.z - sensor.transform.position.z < 8){
            dif = r.transform.position.x - sensor.transform.position.x;
            sensor.GetComponent<Image>().color = new Color(255, 255, 0 ); 

        }
    }
}
