using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public GameObject SVent;
    public GameObject CVent;
    public GameObject DVent;
    public ParticleSystem part1;
    public ParticleSystem part2;
    public ParticleSystem part3;
    public GameObject missPart1;
    public GameObject missPart2;

    public static Pipes S;
    public void Awake()
    {
        if (S == null)
        {
            S = this;
        }
    }

    public void fixS()
    {
        part1.Stop();
        SVent.SetActive(false);
        missPart1.SetActive(true);
    }
    public void fixC()
    {
        part2.Stop();
        CVent.SetActive(false);
        missPart2.SetActive(true);
    }
    public void fixD()
    {
        part3.Stop();
        DVent.SetActive(false);
    }

    public void funcCall(string func)
    {
        Invoke(func,0);
    }
}
