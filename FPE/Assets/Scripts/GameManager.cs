using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text infoText;
    public Image KeyIcon;
    public bool hasKey;

    // Update is called once per frame
    void Update()
    {
        if (hasKey)
        {
            KeyIcon.enabled = true;
        }
        else
        {
            KeyIcon.enabled = false;
        }
    }
}
