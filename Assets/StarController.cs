﻿
using System.Collections;

using UnityEngine;

public class StarController : MonoBehaviour
{
    private float rotSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
