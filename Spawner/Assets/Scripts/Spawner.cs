using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public float CD = 0;
    public GameObject Cube;
    public int Gm = 0;

    public void Start()
    {
        CD = PlayerPrefs.GetFloat("CD", 0);
        Gm = PlayerPrefs.GetInt("Gm", 0);
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        if (CD != 0 && Gm == 1)
        {
            yield return new WaitForSeconds(CD);
            Instantiate(Cube, SpawnPos.position, Quaternion.identity);
            CD = 0;
            Start();
        }
    }

}
