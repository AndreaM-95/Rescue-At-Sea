using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Winner : MonoBehaviour
{
    public GameObject menuWinner;
    
    public void StartCredits(string name){
        SceneManager.LoadScene(name);
    }

    public void StartMenu(string name){
        SceneManager.LoadScene(name);
    }
}
