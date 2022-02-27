using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeRoom : MonoBehaviour
{
    int cost;

    [SerializeField] UnityEngine.AudioClip coin1;
    [SerializeField] UnityEngine.AudioClip denden1;

    private void Start()
    {
    }

    private void OnTriggerStay2D(Collider2D item)
    {
        if (Input.GetMouseButton(0)) { return; }
        cost = FindObjectOfType<DraggableItem>().GetCost();

        if (item.tag == "RealItem")
        {
            GoodSort(item.gameObject);

        }
        else if (item.tag == "FakeItem")
        {
            BadSort(item.gameObject);
        }
    }

    private void GoodSort(GameObject item)
    {
        AudioSource.PlayClipAtPoint(coin1, Camera.main.transform.position);
        FindObjectOfType<Scoreboard>().AddToScore(cost);
        Destroy(item);
    }

    private void BadSort(GameObject item)
    {
        AudioSource.PlayClipAtPoint(denden1, Camera.main.transform.position);
        FindObjectOfType<Scoreboard>().AddToScore(-cost);
        Destroy(item);
    }
}
