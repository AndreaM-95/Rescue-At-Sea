using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeData : MonoBehaviour
{
    public GameObject axe; //Objeto a ubicar
    public Transform hand;   //Lugar donde lo ubicamos

    private bool activo;    //Para saber que estoy dentro de la zona de activación

    public Animator animator; //Animator controller
    public float lanzado;
    private Vector3 escala;
    private bool inHand;

    private void Start() {
        escala = axe.transform.localScale; //Mantendrá la escala original del objeto
    }

    void Update()
    {
        if(activo == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {   
                axe.transform.SetParent(hand); //Le indico que la hacha se debe colocar dentro del player
                axe.transform.position = hand.position; //Que quede en la mano
                axe.transform.rotation = hand.rotation; //Acomoda el objeto según como esté la mano
                axe.GetComponent<Rigidbody>().isKinematic = true;
                inHand = true;
            }
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            axe.transform.SetParent(null);
            axe.GetComponent<Rigidbody>().isKinematic = false;
            
            if(inHand == true){
                animator.Play("Throw");
                axe.GetComponent<Rigidbody>().AddForce(transform.forward * lanzado, ForceMode.Impulse);
                inHand = false;
                axe.transform.localScale = escala; //Para que vuelva a su escala original
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            activo = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player")
        {
            activo = false;
        }
    }
}
