using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Vars
    // stored array of points
    [SerializeField] private Vector3[] spawnPts = null;

    // spawnable Object
    [SerializeField] private GameObject spawnableObj = null;



    // Methods
    private void Update()
    {
        Instantiate(spawnableObj, spawnPts[0],Quaternion.identity);
    }


}
