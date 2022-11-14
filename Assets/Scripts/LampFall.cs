using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampFall : MonoBehaviour
{
    
    public int speedFall = 0;
    Rigidbody rb;
    public ParticleSystem fireFx;
    public float timeFire;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.isKinematic = false;
            rb.AddForce(speedFall * Physics.gravity);
            StartCoroutine(ExampleCoroutine());
            Debug.Log("CoroutineOn");
        }
            
        
    }

    IEnumerator ExampleCoroutine()
    {
       
        yield return new WaitForSeconds(timeFire);
        fireFx.Play(true);
        Debug.Log("FireoN");

    }



}