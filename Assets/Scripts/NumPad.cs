using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumPad : MonoBehaviour
{
    [Header("input in inspector")]
    public Text output;
    private string password = "2490";
    public string input = "";

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
        }
        else
        {
            input = "";
            output.text = "xxxx";
        }
    }
}
