using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StopBtn : MonoBehaviour
{

    public void OnClickStop()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("Gm", 0);
    }
}