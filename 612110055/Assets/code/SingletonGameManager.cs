using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGameManager : Singleton<SingletonGameManager>
{
    protected SingletonGameManager() { }
    public string ClassName { get; } = "SingletonGameManager";

    public int GameScore { get; set; } = 0;
    public int GameScoreTotal { get; set; } = 0;
    public int NumberOfWin { get; set; } = 0;
    public int NumberOfLose { get; set; } = 0;
    public string Name { get; set; } = "";

    public bool gameStart { get; set; } = false;
    public float TimeSSS { get; set; } = 30;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
