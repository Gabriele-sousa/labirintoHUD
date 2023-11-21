using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;


public class entradaSaida : MonoBehaviour
{
    public void Entrar(){
        SceneManager.LoadScene("Scenes/Labirinto");
    }
    public void Sair(){
        Application.Quit();
    }
    void OnTriggerEnter(Collider other){ 
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Scenes/Menu");
        Debug.Log("ai");
    }
}
