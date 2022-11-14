using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;

    public Animator animator; //Animator controller

    private float x, y;        //moviemiento en los ejes 

    //Variables para el salto
    public Rigidbody rb;
    public float jumpHeight = 1.5f;

    public Transform groundCheck; //Verifica si salta sobre un suelo terrestre
    public float groundDistance = 0.1f; //Verifica altura mínima
    public LayerMask groundMask; //Máscara para el suelo
    bool isGrounded;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0); //Girar
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed); //Correr
        animator.SetFloat("VelX", x); //Animación del Movimiento al correr/Girar/Saltar
        animator.SetFloat("VelY", y); //Animación del Movimiento al correr/Girar/Saltar

        //Comprobación si estamos en el suelo
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(Input.GetKey("space") && isGrounded){      //Si oprime la barra y está en el suelo, salte
            animator.Play("Jump"); 
            Invoke("Jump", 1f);
        }
    }

    public void Jump(){
        rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse); //Añade una fuerza hacia arriba con impulso
    }
}
