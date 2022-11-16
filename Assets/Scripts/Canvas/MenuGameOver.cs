using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuGameOver : MonoBehaviour
{
    public GameObject menuGameOver;
    private VidaPlayer playerDead;

    private void Start(){
        playerDead = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
        playerDead.PlayerDead += ActivateMenu;
    }

    private void ActivateMenu(object sender, EventArgs e){
        menuGameOver.SetActive(true);
    }

    public void Restart(){  //carga escena nuevamente (Reiniciar)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void StartMenu(string name){
        SceneManager.LoadScene(name);
    }

    public void Exit(){
        //UnityEditor.EditorApplication.isPlaying = false;    //Para la ejecución del juego
        Application.Quit();
    }
}
