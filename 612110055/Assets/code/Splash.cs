using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Splash : MonoBehaviour
{
    float TimeS = 0;
    public Text timesss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timesss.text = TimeS.ToString("0");
        if (Input.anyKey||TimeS>10)
        {
            Debug.Log("A key or mouse click has been detected");
            SceneManager.LoadScene("SceneMainMenu");
            TimeS = 0;
        }

        TimeS = TimeS + Time.deltaTime;

    }
}
