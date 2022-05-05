using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumPad : MonoBehaviour
{
    [Header("input in inspector")]
    public Text output;
    private string password = "7014";
    public string input = "";
    public GameObject door1;
    public GameObject door2;
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
            //win condition
            door1.SetActive(false);
            door2.SetActive(false);
        }
        else
        {
            input = "";
            output.text = "xxxx";
        }
    }
}
