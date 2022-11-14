using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationElements : MonoBehaviour
{
    public Vector3 rotationChange;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationChange);
    }
}
