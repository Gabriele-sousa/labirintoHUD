using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botao : MonoBehaviour
{
    public GameObject porta;
    public GameObject bot;
    public GameObject sensor;
    public Color cor;
    public SphereCollider esfera;
    // Start is called before the first frame update
    void Start()
    {
         esfera = bot.GetComponent<SphereCollider>();
         sensor = GameObject.FindGameObjectWithTag("radar");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other){ 
        if(other.gameObject.tag == "jogador"){
            sensor.GetComponent<Image>().color = cor;
        }
    }
    void OnTriggerExit(Collider other){ 
        if(other.gameObject.tag == "jogador"){
            sensor.GetComponent<Image>().color = new Color(255,255,255,255);
        }
    }
    void OnCollisionEnter(Collision other){
          porta.transform.Translate(0,45,0);
    }
}
