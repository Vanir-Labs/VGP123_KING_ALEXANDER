//RandSpawnItem
//By: Lex King
//Spawns randomized objects in specific locations on the map
// =================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawnItem : MonoBehaviour
{
    public Transform pos;
    public GameObject[] objectsToInstantiate;
    float min = 1;
    float max = 101;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateObject();
    }

    void Update ()
    {
   //Every frame, a new random number between 0 and 101
//        Random.Range (min, max);
    }

    private void InstantiateObject()
    {
        int r = Random.Range(0, objectsToInstantiate.Length);
        Instantiate(objectsToInstantiate[r], pos.position, objectsToInstantiate[r].transform.rotation);
    }
//End of Script
}
