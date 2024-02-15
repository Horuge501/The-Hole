using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleAbsorp : MonoBehaviour
{
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
                Destroy(gameObject);
            }
        }
    }
}
