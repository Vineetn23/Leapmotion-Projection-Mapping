using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objToSpawn;
    public Vector3 spawnLocation;

    public void SpawnSphere()
    {
        Instantiate(objToSpawn, spawnLocation, Quaternion.identity);
    }
    
}
