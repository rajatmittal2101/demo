﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthMonitor : MonoBehaviour
{
    private Image health_UI;
    
   
    
   
    // Start is called before the first frame update
    void Awake()
    {
        health_UI = GameObject.FindWithTag("HealthUI").GetComponent<Image>();
    }

    public void DisplayHealth(float value)
    {
        value /= 100f;

        if (value < 0f)
            value = 0f;

        health_UI.fillAmount = value;
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
}
