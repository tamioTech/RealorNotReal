using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    [SerializeField] GameObject prefab;

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
        if (!Input.GetKey(KeyCode.R)) { return; }
        //gameObject.transform.position = respawnPoint.position;
        Instantiate(prefab, respawnPoint.position, Quaternion.identity);
    }
}
