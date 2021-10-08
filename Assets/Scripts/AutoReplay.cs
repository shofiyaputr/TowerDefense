using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AutoReplay : MonoBehaviour
{
    float timer = 0;
    public Text info;

    void Start()
    {
        if (Data.isComplete)
        {
            info.text = "GOOD JOB \n YOU WIN!";
        }
        else
        {
            info.text = "Sorry Dear \n You Haven't Won Today, Don't Cry!";
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            Data.isGameOver = false;
            Data.isComplete = false;
            Data.coin = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
