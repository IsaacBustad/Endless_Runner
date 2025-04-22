using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemy : MonoBehaviour
{
    // Vars
    // stored array of points
    [SerializeField] private Vector3[] spawnPts = null;

    // spawnable Object
    [SerializeField] private GameObject spawnableObj = null;

    // set up coroutine
    [SerializeField] private float timeToSpawn = 2f;
    private WaitForSeconds waitToSpawn = null;
    private bool isSpawning = false;



    // Methods
    private void OnEnable()
    {
        waitToSpawn = new WaitForSeconds(timeToSpawn);
    }
    private void Update()
    {
        if (isSpawning == false)
        {
            StartCoroutine(SpawnOnDelay());
            // StopCoroutine(SpawnOnDelay());
            // StopAllCoroutines();
        }
    }

    IEnumerator SpawnOnDelay()
    {
        // setup before yield
        isSpawning = true;

        yield return waitToSpawn;

        // execution post yeild

        // spawn enemy
        int nIDX = Random.Range(0, spawnPts.Length - 1);
        
        GameObject aGO = Instantiate(spawnableObj, spawnPts[nIDX], Quaternion.identity);

        // reset bool
        isSpawning = false;
    }

}
