using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCan : MonoBehaviour
{
    int cost;

    private void OnTriggerStay2D(Collider2D item)
    {
        if (Input.GetMouseButton(0)) { return; }
        print("triggered - it's in the can! ANALYZING...");
        cost = FindObjectOfType<DraggableItem>().GetCost();
        if (item.tag == "RealItem")
        {
            FindObjectOfType<Scoreboard>().AddToScore(-cost);
            print("Real Item thrown out");
            Destroy(item.gameObject);
            //StartCoroutine(InTheGarbage(item));
        }
        else if (item.tag == "FakeItem")
        {
            FindObjectOfType<Scoreboard>().AddToScore(1);
            print("Fake Item thrown out");
            //StartCoroutine(InTheGarbage(item));
            Destroy(item.gameObject);
        }
    }

    //private void OnTriggerEnter2D(Collider2D item)
    //{
    //    if (Input.GetMouseButton(0)) { return; }
    //    print("triggered - it's in the can! ANALYZING...");
    //    cost = FindObjectOfType<DraggableItem>().GetCost();
    //    if (item.tag == "RealItem")
    //    {
    //        FindObjectOfType<Scoreboard>().AddToScore(-cost);
    //        print("Real Item thrown out");
    //        StartCoroutine(InTheGarbage(item));
    //    }
    //    else if (item.tag == "FakeItem")
    //    {
    //        FindObjectOfType<Scoreboard>().AddToScore(1);
    //        print("Fake Item thrown out");
    //        StartCoroutine(InTheGarbage(item));

    //    }
    //}

    //IEnumerator InTheGarbage(Collider2D item)
    //{
    //    yield return new WaitForSeconds(1);
    //    Destroy(item.gameObject);
    //}

}
