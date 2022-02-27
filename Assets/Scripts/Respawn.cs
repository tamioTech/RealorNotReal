using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    [SerializeField] GameObject[] prefab;
    [SerializeField] public float spawnTime = 5f;
    [SerializeField] float gameSpeed = 1f;

    float currentTime;
    float timer;
    float startTimerTime;

    void Start()
    {
        //InvokeRepeating("Spawner", spawnTime, spawnTime);
    }

    void Update()
    {
        ResetPosition();
        SpawnItem();
    }

    public void SpawnItem()
    {
        currentTime = Time.time - startTimerTime;
        timer = Mathf.Round(currentTime * gameSpeed);
        print(timer);
        if (timer > spawnTime)
        {
            int rngPrefab = Random.Range(0, prefab.Length);
            Instantiate(prefab[rngPrefab], RandomPosition(), Quaternion.EulerRotation(0, 0, Random.Range(0f, 360f)));
            startTimerTime = Time.time;
            timer = 0;
        }

    }

    private void ResetPosition()
    {
        if (!Input.GetKeyDown(KeyCode.R)) { return; }
        int rngPrefab = Random.Range(0, prefab.Length);

        Instantiate(prefab[rngPrefab], RandomPosition(), Quaternion.EulerRotation(0,0,Random.Range(0f,360f)));

    }

    public Vector3 RandomPosition()
    {
        print("RandomPosition()");
        float rngX = Random.Range(-4.5f, 4.5f);
        float rngY = Random.Range(-1.5f, 1.5f);
        Vector3 rndPos = new Vector3(rngX, rngY, 0);
        print("Return: " + rndPos);
        return rndPos;
    }

}
