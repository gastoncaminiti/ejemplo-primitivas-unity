using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    private void OnCollisionEnter(Collision other)
    {
        score++;
        Debug.Log("SCORE " + score);
    }
}
