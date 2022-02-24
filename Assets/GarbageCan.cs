using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCan : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D item)
    {
        print("triggered - it's in the can! ANALYZING...");
        if (item.tag == "RealItem")
        {
            print("Real Item thrown out");
            StartCoroutine(InTheGarbage(item));
        }
        else if (item.tag == "FakeItem")
        {
            print("Fake Item thrown out");
            StartCoroutine(InTheGarbage(item));
        }
    }

    IEnumerator InTheGarbage(Collider2D item)
    {
        yield return new WaitForSeconds(1);
        Destroy(item.gameObject);
    }

}
