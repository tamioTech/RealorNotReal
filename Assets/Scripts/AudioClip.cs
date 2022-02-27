using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClip : MonoBehaviour
{

    [SerializeField] AudioClip coin;
    [SerializeField] AudioClip denden;

    AudioSource audioSource;

    




    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGoodSound()
    {
        StartCoroutine(GoodSound());
    }

    public void PlayBadSound()
    {
        StartCoroutine(BadSound());
    }

    IEnumerator GoodSound()
    {
        AudioSource.PlayClipAtPoint(coin.audioSource.clip, Camera.main.transform.position);
       // audioSource.clip = coin.audioSource.clip;
        //audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }

    IEnumerator BadSound()
    {
        //AudioSource.PlayClipAtPoint(coin1, Camera.main.transform.position);
        audioSource.clip = denden.audioSource.clip;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }
}
