﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    public GameObject pivot;

    // Start is called before the first frame update
    void Start()
    {
        pivot.transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
