    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipuladorVida : MonoBehaviour
{   
    VidaPlayer playerVida;
    public int cantidad; //La cantidad de vida que me quitará
    public float damageTime;
    float currentDamageTime;
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            currentDamageTime += Time.deltaTime;
            if(currentDamageTime > damageTime){
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
            }
        }
    }
}
