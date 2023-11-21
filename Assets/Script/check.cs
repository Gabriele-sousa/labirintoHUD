using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    
    public GameObject jogador;
    public GameObject isso;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){ 
        var j = jogador.GetComponent<personagem>();
        Debug.Log("checkpoint!!");
        j.checkX = isso.transform.position.x;
        j.checkY = isso.transform.position.z;
        Debug.Log(j.checkX);
        //checkY = isso.transform.position.z;
        Destroy(isso);
        Destroy(this);
    }
}
