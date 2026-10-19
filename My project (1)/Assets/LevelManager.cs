using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        currentCheckpoint = null;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer()
    {
        FindObjectOfType<character>().transform.position = currentCheckpoint.transform.position;
    }
}
