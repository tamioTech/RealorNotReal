using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    [SerializeField] GameObject[] prefab;
    [SerializeField] float spawnTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        ResetPosition();
        //Spawner();
    }

    private void Spawner()
    {
        int rngPrefab = Random.Range(0, prefab.Length);
        Instantiate(prefab[rngPrefab], RandomPosition(), Quaternion.EulerRotation(0, 0, Random.Range(0f, 360f)));
    }

    private void ResetPosition()
    {
        int rngPrefab = Random.Range(0, prefab.Length);
        if (!Input.GetKeyDown(KeyCode.R)) { return; }

        Instantiate(prefab[rngPrefab], RandomPosition(), Quaternion.EulerRotation(0,0,Random.Range(0f,360f)));

    }

    public Vector3 RandomPosition()
    {
        print("RandomPosition()");
        float rngX = Random.Range(-5f, 5f);
        float rngY = Random.Range(-2f, 2f);
        Vector3 rndPos = new Vector3(rngX, rngY, 0);
        print("Return: " + rndPos);
        return rndPos;
    }

}
