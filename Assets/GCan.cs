using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision: "+collision);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("triggered: " + collision);
    }
}
