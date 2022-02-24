using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    [SerializeField] GameObject[] prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetPosition();
    }

    private void ResetPosition()
    {
        int rngPrefab = Random.Range(0, prefab.Length);
        
        if (!Input.GetKey(KeyCode.R)) { return; }
        //gameObject.transform.position = respawnPoint.position;
        Instantiate(prefab[rngPrefab], RandomPosition(), Quaternion.identity);

    }

    public Vector3 RandomPosition()
    {
        print("RandomPosition()");
        float rngX = Random.Range(-7.5f, 7.5f);
        float rngY = Random.Range(-3.5f, 3.5f);
        Vector3 rndPos = new Vector3(rngX, rngY, 0);
        print("Return: " + rndPos);
        return rndPos;
    }
}
