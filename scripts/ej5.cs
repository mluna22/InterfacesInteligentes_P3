using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5 : MonoBehaviour
{
    public float speed;
    GameObject sphere;
    void Start()
    {
        sphere = GameObject.Find("Sphere");
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || 
        Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            gameObject.transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);    
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || 
        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            sphere.transform.Translate(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical2") * speed * Time.deltaTime);    
        }
    }
}
