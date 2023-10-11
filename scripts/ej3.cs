using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;
    void Start()
    {
        Vector3 pos = gameObject.transform.position;
        pos.y = 0;
        gameObject.transform.position = pos;
    }

    
    void Update()
    {
        gameObject.transform.Translate(moveDirection * speed, Space.World);
    }
}
