using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenuControlScript : MonoBehaviour
{
    [SerializeField] Dropdown _dropdownDifficulty;
    [SerializeField] Toggle _toggleMusic;
    [SerializeField] Toggle _toggleSFX;
    [SerializeField] Button _backButton;

    private void Start()
    {
        _dropdownDifficulty.value = GameApplicationManager.Instance.DificulyLevel;
        _toggleMusic.isOn = GameApplicationManager.Instance.MusicEnabled;
        _toggleSFX.isOn = GameApplicationManager.Instance.SFXEnabled;
        _dropdownDifficulty.onValueChanged.AddListener(delegate { DropdownDifficultyChanged(_dropdownDifficulty); });
        _toggleMusic.onValueChanged.AddListener(delegate { OnToggleMusic(_toggleMusic); });
        _toggleSFX.onValueChanged.AddListener(delegate { OnToggleSFX(_toggleSFX); });
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });

        //SceneMainMenu
    }
   
    public void DropdownDifficultyChanged(Dropdown dropdown)
    {
        GameApplicationManager.Instance.DificulyLevel = dropdown.value;
    }
    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneOptions");
       GameApplicationManager.Instance.IsOptionMenuActive = false;
    }
    public void OnToggleMusic(Toggle toggle)
    {
        GameApplicationManager.Instance.MusicEnabled = _toggleMusic.isOn;
        if (GameApplicationManager.Instance.MusicEnabled)
            SingletonSoundManager.Instance.MusicVolume = SingletonSoundManager.Instance.MusicVolumeDefault;
        else
            SingletonSoundManager.Instance.MusicVolume = SingletonSoundManager.MUTE_VOLUME;
    }
    public void OnToggleSFX(Toggle toggle)
    {
        GameApplicationManager.Instance.MusicEnabled = _toggleSFX.isOn;
        if (GameApplicationManager.Instance.SFXEnabled)
            SingletonSoundManager.Instance.MasterSFXVolume = SingletonSoundManager.Instance.MasterSFXVolumeDefault;
        else
            SingletonSoundManager.Instance.MasterSFXVolume = SingletonSoundManager.MUTE_VOLUME;

    }


}

