using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplicationManager :Singleton<GameApplicationManager>
{ 
  

    public string[] DIFICULY_LEVEL_NAME = { "Easy", "Normal", "Hard", "Extreme" };
    // Update is called once per frame
    public bool IsOptionMenuActive
    {
        get { return _isOptionMenuActive; }
        set
        {
            _isOptionMenuActive = value;
        }
    }
    protected bool _isOptionMenuActive = false;

    public int DificulyLevel {get;set;}
    public bool MusicEnabled { get; set; } = true;

    public bool SFXEnabled { get; set; } = true;

}
