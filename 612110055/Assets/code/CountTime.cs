using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountTime : MonoBehaviour
{
   public Text TimeText;
    float time=5;

    private void Update()
    {
        if (time <= 0)
        {
            SceneManager.LoadScene("SceneMainMenu");
        }
        time = time - Time.deltaTime;
        TimeText.text = time.ToString("0")+": s";
    }
}
