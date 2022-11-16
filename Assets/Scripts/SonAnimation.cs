using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SonAnimation : MonoBehaviour
{
    public Animator animatorSon; //Animator controller
    

    private bool winner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            winner = true;
            SceneManager.LoadScene("Winner");
        }
    }
}
