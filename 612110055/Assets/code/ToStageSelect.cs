using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ToStageSelect : MonoBehaviour
{
    [SerializeField] Button _backButton;
    public Text Score;
    public Text Gamewin;
    public Text GameLose;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "GameScore" + SingletonGameManager.Instance.GameScore.ToString();
        Gamewin.text = "NumberOfWin" + SingletonGameManager.Instance.NumberOfWin.ToString();
        GameLose.text = "NumberOfLose"+SingletonGameManager.Instance.NumberOfLose.ToString();

    }
    public void BackToMainMenuButtonClick(Button button)
    {

        SceneManager.LoadScene("StageSelect");
    }
}
