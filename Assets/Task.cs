﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    void Start()
    {
        int[] array = {1, 2, 3, 4, 5};
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for(int a = array.Length-1; a >= 0; a--)
        {
            Debug.Log(array[a]);
        }
        
    }
}
