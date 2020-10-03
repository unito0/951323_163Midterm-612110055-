using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonToNextScene : MonoBehaviour
{
    [SerializeField] Button _Button;
    public string NameOfNextScene;

    public void ButtonClick(Button button) { SceneManager.LoadScene(NameOfNextScene); }

   
    private void Start()
    {
        _Button.onClick.AddListener(delegate { ButtonClick(_Button); });
       
    }
}
