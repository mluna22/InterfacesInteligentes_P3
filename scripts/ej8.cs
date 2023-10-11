using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8 : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * 10, Color.green);
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * speed, 0, Space.World);
        }
        gameObject.transform.Translate(gameObject.transform.forward * speed * Time.deltaTime, Space.World);
    }
}
