using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Librería
using System;

public class VidaPlayer : MonoBehaviour
{   
    VidaPlayer player;

    public float vida = 100;
    public Image barraDeVida;
    
    public event EventHandler PlayerDead;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
    }

    void Update()
    {
        //La vida no pasará de un máximo ni disminuirá de un mínimo
        vida = Mathf.Clamp(vida, 0, 100);
        barraDeVida.fillAmount = vida / 100; //Tomará la barra de vida y la llenará o deisminuirá

        if(vida == 0){
            PlayerDead?.Invoke(this, EventArgs.Empty);
            Debug.Log("Game Over!");
            Destroy(player);
        }
    }
}
