using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class NumPad : MonoBehaviour
{
    [Header("input in inspector")]
    public Text output;
    public GameObject door1;
    public GameObject door2;
    private string password = "7014";
    public string input = "";
    public GameObject key;

    public void inputNum(string num)
    {
        string temp = "";
        if(input.Length >= 4)
        {
            input = "";
        }
        input += num;
        temp += input;
        for(int i = 0; i < 4 - input.Length; i++)
        {
            temp += "x";
        }
        output.text = temp;
    }

    public void submit()
    {
        if(input.Equals(password))
        {
            print("win");
            door1.SetActive(false);
            door2.SetActive(false);
            //win condition
            key.AddComponent<XRGrabInteractable>();
        }
        else
        {
            input = "";
            output.text = "xxxx";
        }
    }
}
