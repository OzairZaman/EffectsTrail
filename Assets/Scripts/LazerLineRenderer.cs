using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerLineRenderer : MonoBehaviour
{

    #region variables
    public LineRenderer lazer;
    float growth = 1;
    float growthSpeed = 5;
    #endregion

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        growth += Time.deltaTime * growthSpeed;
        lazer.SetPosition(1, new Vector3(0, 0, growth));
    }
}
