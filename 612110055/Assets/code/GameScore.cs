using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour
{
   
    public Text Textoftime;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Textoftime.text = "Time : " + SingletonGameManager.Instance.TimeSSS.ToString("0") + " Left";
           SingletonGameManager.Instance.TimeSSS = SingletonGameManager.Instance.TimeSSS - Time.deltaTime;
        SingletonGameManager.Instance.GameScore = (int)SingletonGameManager.Instance.TimeSSS * 1000;
        if ( SingletonGameManager.Instance.gameStart )
        {
            SingletonGameManager.Instance.TimeSSS = 30;


            if (SingletonGameManager.Instance.TimeSSS <= 0)
            {
            SingletonGameManager.Instance.gameStart = false;
                SceneManager.LoadScene("SceneMainMenu");
            }
               

        }
        if (player.transform.position.y < -10)
        {
            SingletonGameManager.Instance.gameStart = false;
            SceneManager.LoadScene("SceneMainMenu");
            SingletonGameManager.Instance.NumberOfLose += 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.NumberOfWin += 1;
            SceneManager.LoadScene("Stage2");
            SingletonGameManager.Instance.GameScoreTotal += SingletonGameManager.Instance.GameScore;
            SingletonGameManager.Instance.TimeSSS = 30;
        }
    }
}
