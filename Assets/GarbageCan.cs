using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCan : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D item)
    {
        print("triggered - it's in the hole! ANALYZING...");
        if (item.tag != "GarbagCan")
        {
            StartCoroutine(SpitBallOut(item));
        }
        else
        {
            StartCoroutine(InTheGarbage(item));
        }
    }

    


    IEnumerator InTheGarbage(Collider2D item)
    {
        yield return new WaitForSeconds(1);
        Destroy(item.gameObject);
    }

    IEnumerator SpitBallOut(Collider2D item)
    {
        yield return new WaitForSeconds(1);
        item.gameObject.transform.position = FindObjectOfType<Respawn>().RandomPosition();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
    }
}
