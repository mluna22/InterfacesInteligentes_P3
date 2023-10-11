using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej9 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        Debug.Log(gameObject.name + " chocó con " + collider.gameObject.name);
    }
}
