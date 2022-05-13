using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public float startTime;
    public float endTime;
    public GameObject player;
    public Vector3 start;
    public Vector3 end;
    public Text timer;
    public static Main S;
    public void Awake()
    {
        if(S == null)
        {
            S = this;
        }
    }
    public void escStart()
    {
        startTime = Time.time;
        player.transform.position = start;
    }
    public void escEnd()
    {
        endTime = Time.time;
        player.transform.position = end;
        string tottime = ("Completion Time: "+ (endTime - startTime).ToString());
        timer.text = tottime;
    }

    public void reload()
    {
        SceneManager.LoadScene(0);
    }
}
