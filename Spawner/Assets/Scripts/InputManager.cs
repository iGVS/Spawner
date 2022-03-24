using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField InputResp;
    public InputField InputSpeed;
    public InputField InputRange;
    public float Speed = 0;
    public float CD = 0;
    public float Range = 0;
//    public Text SetTxt;

    public void OnStart()
    {
        CD = float.Parse(InputResp.text);
        Speed = float.Parse(InputSpeed.text);
        Range = float.Parse(InputRange.text);
//        SetTxt.text = "Респ: " + CD + "  Скорость: " + Speed + "Расстояние: " + Range;
        PlayerPrefs.SetFloat("CD", CD);
        PlayerPrefs.SetFloat("Speed", Speed);
        PlayerPrefs.SetFloat("Range", Range);
    }
/*
    public void SaveSet()
    {
        PlayerPrefs.SetFloat("CD", CD);
        PlayerPrefs.SetFloat("Speed", Speed);
        PlayerPrefs.SetFloat("Range", Range);
    }
*/
}
