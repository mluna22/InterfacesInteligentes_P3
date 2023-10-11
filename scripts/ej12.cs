using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej12 : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || 
        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            if (rb.isKinematic) transform.Translate(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical2") * speed * Time.deltaTime);
            else rb.AddForce(Input.GetAxis("Horizontal2") * speed, 0, Input.GetAxis("Vertical2") * speed, ForceMode.VelocityChange);
        }
    }
}
