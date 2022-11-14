using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Credits : MonoBehaviour
{
    public GameObject menuCredits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartCredits(string name){
        SceneManager.LoadScene(name);
    }
}
