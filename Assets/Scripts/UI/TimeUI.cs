using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    void Update()
    {
        timeText.text = DateTime.Now.ToString("tt hh:mm");
    }
}
