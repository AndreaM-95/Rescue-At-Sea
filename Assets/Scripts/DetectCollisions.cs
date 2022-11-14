using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    VidaPlayer playerLife;
    public int cantidadLife; //La cantidad de vida que me quitará
    public float damaTime;
    float currentDamaTime;

    // Start is called before the first frame update
    void Start()
    {
        playerLife = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            currentDamaTime += Time.deltaTime;
            if(currentDamaTime > damaTime){
                playerLife.vida += cantidadLife;
                currentDamaTime = 0.0f;
                Debug.Log("Toma vida");
                Destroy(gameObject);
            }
        }
    }
}
