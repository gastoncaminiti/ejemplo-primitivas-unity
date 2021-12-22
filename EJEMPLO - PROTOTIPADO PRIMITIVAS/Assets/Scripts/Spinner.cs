using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] private float xAxis = 0f;   
    [SerializeField] private float yAxis = 1f;   
    [SerializeField] private float zAxis = 0f;   
    void Update()
    {
        transform.Rotate(xAxis,yAxis,zAxis);
    }
}
