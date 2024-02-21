using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI TMP;

    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        score++;
        TMP.text = "Score = " + score.ToString();
        print(score);
    }
}
