using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag("Enemy")) {
            Destroy(other.gameObject);
        }
    }
}
