using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, Mathf.Infinity))
        {
            if(hit.collider.gameObject.name == "False Wall")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
