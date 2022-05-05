using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    private GameObject Player;
    private void Start()
    {
        Player = this.gameObject;

    }
    public void teleportPlayer() {
        Player.transform.position = new Vector3(14f,-6f,-22f);
    }
}
