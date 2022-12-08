using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour
{
    public Text UserNameBox;

    private void Start()
    {
        UserNameBox.text = PlayerPrefs.GetString("username");
    }
}
