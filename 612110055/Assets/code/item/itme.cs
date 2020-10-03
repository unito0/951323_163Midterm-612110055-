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
    private void Start()
    {
        int temp = Random.Range(-4, 2);

        gameObject.transform.position = new Vector3(temp, transform.position.y, transform.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(isRed&&collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.TimeSSS -= 5;
            Destroy(gameObject);

        }
        if (isGreen && collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.TimeSSS += 3;
            Destroy(gameObject);

        }
        if (isBlue && collision.gameObject.CompareTag("Player"))
        {
            SingletonGameManager.Instance.GameScoreTotal += 500;
            Destroy(gameObject);

        }
        if (isDark && collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
