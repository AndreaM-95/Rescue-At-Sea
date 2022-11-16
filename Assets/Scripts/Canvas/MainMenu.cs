using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{   
    public GameObject menuMain;
    
    public void StartPlay(string name){
        SceneManager.LoadScene(name);
    }

    public void StartCredits(string name){
        SceneManager.LoadScene(name);
    }

    public void Exit(){
        //UnityEditor.EditorApplication.isPlaying = false;    //Para la ejecución del juego
        Application.Quit();
    }

}
