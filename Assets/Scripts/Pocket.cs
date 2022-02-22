using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocket : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D item)
    {
        print("triggered - it's in the hole!");
        StartCoroutine(InTheHole(item));
    }

    IEnumerator InTheHole(Collider2D item)
    {
        yield return new WaitForSeconds(1);
        Destroy(item.gameObject);
    }


}
