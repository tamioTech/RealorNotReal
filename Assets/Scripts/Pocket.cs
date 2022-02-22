using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocket : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("triggered - it's in the hole!");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collided - one in the bag");
    }

}
