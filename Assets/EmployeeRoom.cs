using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeRoom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D item)
    {
        print("triggered");
        print("triggered - it's in the hole! ANALYZING...");
        if (item.tag != "EmployeeRoom")
        {
            StartCoroutine(SpitBallOut(item));
        }
        else
        {
            StartCoroutine(InTheBackroom(item));
        }
    }


    IEnumerator InTheBackroom(Collider2D item)
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
