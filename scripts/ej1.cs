using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) Debug.Log("Flecha hacia arriba pulsada con velocidad " + (Input.GetAxis("Vertical") * speed));
        if (Input.GetKey(KeyCode.DownArrow)) Debug.Log("Flecha hacia abajo pulsada con velocidad " + (Input.GetAxis("Vertical") * speed));
        if (Input.GetKey(KeyCode.LeftArrow)) Debug.Log("Flecha hacia la derecha pulsada con velocidad " + (Input.GetAxis("Horizontal") * speed));
        if (Input.GetKey(KeyCode.RightArrow)) Debug.Log("Flecha hacia la izquierda pulsada con velocidad " + (Input.GetAxis("Horizontal") * speed));
    }
}
