using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public Text _Name;
    private void Start()
    {
        SingletonGameManager.Instance.Name = _Name.text;
    }

    private void Update()
    {
        _Name.text = SingletonGameManager.Instance.Name;
    }

}
