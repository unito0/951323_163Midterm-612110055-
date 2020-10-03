using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MainMenuControlScript : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _helpButton;
    [SerializeField] Button _exitButton;


    AudioSource audiosourceButtomUI;
    [SerializeField] AudioClip audioclipHoldOver;
    
    private void Start()
    {
        this.audiosourceButtomUI = this.gameObject.AddComponent<AudioSource>();
        this.audiosourceButtomUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer.FindMatchingGroups("MasterSFXVolume")[0];
        SetupDelegate();

        if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();


    }
    void SetupDelegate()
    {
        _startButton.onClick.AddListener(delegate { StartButtonClick(_startButton); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _exitButton.onClick.AddListener(delegate { ExitButtonCilck(_exitButton); });
        _helpButton.onClick.AddListener(delegate { HelpButtonClick(_helpButton); });
    
    }
 public void  OnPointerEnter(PointerEventData eventData)
    {
        if (audiosourceButtomUI.isPlaying)
            audiosourceButtomUI.Stop();

        audiosourceButtomUI.PlayOneShot(audioclipHoldOver);
    }
    public void StartButtonClick(Button button) { SceneManager.LoadScene("StageSelect"); }

    public void OptionsButtonClick(Button button)
    {
        if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }

    }
   
    public void HelpButtonClick(Button button) { SceneManager.LoadScene("Credits"); }
    public void ExitButtonCilck(Button button)
    {
        Application.Quit();
    }


}
