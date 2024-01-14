using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class outOfBOunds : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
    }
}
