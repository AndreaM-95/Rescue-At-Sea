using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject cajaFragmentos;

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Axe"){
            Instantiate(cajaFragmentos, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
