using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionP : MonoBehaviour
{
    public string func;
    public string named;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == named)
        {
            Pipes.S.funcCall(func);
            Destroy(other.gameObject);
        }
    }
}
