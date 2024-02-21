using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleAbsorp : MonoBehaviour
{
    public GameObject gameOver;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Absorbed")) {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.useGravity = true;
            }
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Inestable")) {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null) {
                gameOver.SetActive(true);
                Scoring.score = 0;
                Destroy(gameObject);
            }
        }
    }
}
