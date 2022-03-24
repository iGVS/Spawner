using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{
    public GameObject Cube;
    float S = 0;

    public void FixedUpdate()
    {
        S = PlayerPrefs.GetFloat("Speed");
        Cube.transform.Translate(0, 0, S * Time.deltaTime);
    }
}
