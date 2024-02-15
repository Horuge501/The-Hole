using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int score = 0;

    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        score++;
        print(score);
    }
}
