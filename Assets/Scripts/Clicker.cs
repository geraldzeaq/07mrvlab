﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public bool clicked()
    {
#if (UNITY_ANDROID || UNITY_IPHONE)
        return Cardboard.SDK.CardboardTriggered;
#else
        return Input.anyKeyDown;
#endif
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}