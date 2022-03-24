using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject Cube;
    public float R = 0;
    public float S = 0;
    public float F = 0;

    public void Update()
    {
        S = PlayerPrefs.GetFloat("Speed");
        R = PlayerPrefs.GetFloat("Range");
        F = R / S;
        Destroy(Cube, F);
    }

}
