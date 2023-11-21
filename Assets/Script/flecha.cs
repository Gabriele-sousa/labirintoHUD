using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flecha : MonoBehaviour
{
    public GameObject jogador;
    public GameObject flechas;
    public GameObject coracao;
    public GameObject coracao1;
    public int vel;
    // Start is called before the first frame update
    void Start()
    {
        coracao = GameObject.FindGameObjectWithTag("vida");
        coracao1 = GameObject.FindGameObjectWithTag("vida1");
        vel = -2;
    }

    // Update is called once per frame
    void Update()
    {
        coracao.transform.Translate(0,100,0);
        jogador = GameObject.FindGameObjectWithTag("jogador");
        flechas = GameObject.FindGameObjectWithTag("flecha");
        
        flechas.transform.Translate(0, (vel * Time.deltaTime) * 5, 0);

    }
    void OnCollisionEnter(Collision other){ 
        Destroy(flechas);
        Destroy(this);
        if(other.gameObject.tag == "jogador"){
            var j = jogador.GetComponent<personagem>();
            j.transform.position = new Vector3(j.checkX, j.transform.position.y, j.checkY);  
            j.vida = 2.0f;
        }
        return;
    }
}
