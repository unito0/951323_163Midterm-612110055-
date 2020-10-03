using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itme : MonoBehaviour
{
    [SerializeField]
    public bool isRed;
 [SerializeField]
    public bool isGreen;
 [SerializeField]
    public bool isBlue;
  [SerializeField]
    public bool isDark;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(isRed&&collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.TimeSSS -= 5;

        }
        if (isGreen && collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.TimeSSS += 3;

        }
        if (isBlue && collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.GameScoreTotal += 500;

        }
        if (isDark && collision.gameObject.CompareTag("Player"))
        {
            
        }
    }
}
