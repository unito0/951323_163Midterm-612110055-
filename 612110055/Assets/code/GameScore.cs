using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour
{
   
    public Text Textoftime;
    public GameObject player;
    public bool LV1=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Textoftime.text = "Time : " + SingletonGameManager.Instance.TimeSSS.ToString("0") + " Left";
           SingletonGameManager.Instance.TimeSSS = SingletonGameManager.Instance.TimeSSS - Time.deltaTime;
        SingletonGameManager.Instance.GameScore = (int)SingletonGameManager.Instance.TimeSSS * 1000 + SingletonGameManager.Instance.GameScoreTotal;


        

            if (SingletonGameManager.Instance.TimeSSS <= 0)
            {
       
                SceneManager.LoadScene("StageSelect");
            SingletonGameManager.Instance.TimeSSS = 30;
        }
               

        
        if (player.transform.position.y < -10)
        {
         
            SceneManager.LoadScene("StageSelect");
            SingletonGameManager.Instance.NumberOfLose += 1;
            SingletonGameManager.Instance.TimeSSS = 30;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.NumberOfWin += 1;
            if(LV1)
            SceneManager.LoadScene("Stage2");
            else
                SceneManager.LoadScene("SceneMainMenu");
            SingletonGameManager.Instance.GameScoreTotal += SingletonGameManager.Instance.GameScore;
            SingletonGameManager.Instance.TimeSSS = 30;
        }
    }
}
