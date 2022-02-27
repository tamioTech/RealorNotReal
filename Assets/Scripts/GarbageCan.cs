using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCan : MonoBehaviour
{
    int cost;

    [SerializeField] UnityEngine.AudioClip coin1;
    [SerializeField] UnityEngine.AudioClip denden1;
    AudioSource audioSource;
    GameObject parentObj;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay2D(Collider2D item)
    {
        if (Input.GetMouseButton(0)) { return; }
        print("triggered - it's in the can! ANALYZING...");
        cost = FindObjectOfType<DraggableItem>().GetCost();

        if (item.tag == "RealItem")
        {
            
            print("Real Item thrown out");
            //StartCoroutine(PlayBadAudio(item.gameObject));
            //FindObjectOfType<AudioClip>().PlayBadSound();
            BadSort(item.gameObject);
            
        }
        else if (item.tag == "FakeItem")
        {
            print("Fake Item thrown out");
            //FindObjectOfType<AudioClip>().PlayGoodSound();
            //StartCoroutine(PlayGoodAudio(item.gameObject));
            GoodSort(item.gameObject);
        }
    }

    private void GoodSort(GameObject item)
    {
        AudioSource.PlayClipAtPoint(coin1, Camera.main.transform.position);

        FindObjectOfType<Scoreboard>().AddToScore(1);
        Destroy(item);
    }

    private void BadSort(GameObject item)
    {
        AudioSource.PlayClipAtPoint(denden1, Camera.main.transform.position);

        FindObjectOfType<Scoreboard>().AddToScore(-cost);
        Destroy(item);
    }
}


