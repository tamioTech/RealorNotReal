using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocket : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D item)
    {
        print("triggered - it's in the hole! ANALYZING...");
        if (item.tag != gameObject.tag)
        {
            StartCoroutine(SpitBallOut(item));
        }
        else
        {
            StartCoroutine(InTheHole(item));
        }
    }


    IEnumerator InTheHole(Collider2D item)
    {
        yield return new WaitForSeconds(1);
        Destroy(item.gameObject);
    }

    IEnumerator SpitBallOut(Collider2D item)
    {
        yield return new WaitForSeconds(1);
        item.gameObject.transform.position = FindObjectOfType<Respawn>().RandomPosition();
    }


}
