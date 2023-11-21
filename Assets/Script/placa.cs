using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placa : MonoBehaviour
{
    public GameObject jogador;
    public GameObject flechas;
    public Vector3 posicao;
    public Vector3 posicao2;
    public Quaternion rotacao;
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
        Instantiate(flechas, posicao, rotacao);
        Instantiate(flechas, posicao2, rotacao);
    }
}
