﻿using UnityEngine;
using System.Collections;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager instance;

    // local scale size
    public float GridSize = 2f; 
    


    void Awake()
    {
        instance = this;
        
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
