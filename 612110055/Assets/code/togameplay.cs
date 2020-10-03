using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class togameplay : MonoBehaviour
{
    // Start is called before the first frame update
  public void lv1()
    {
        SceneManager.LoadScene("Stage1"); ;
    }
    public void lv2()
    {
        SceneManager.LoadScene("Stage2"); ;
    }

}
