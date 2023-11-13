using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefabs;
    private float spawnPositionZ = 30.0f;
    private float spawnRangeX = 20.0f;
    private float startDelay = 2.0f;
    private float startDelayLeft = 4.0f;
    private float startDelayRight = 6.0f;
    private float spawnInterval = 1.5f;
    private float sideSpawnMinZ = 3;
    private float sideSpawnMaxZ = 14;
    private float sideSpawnX = 25;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //InvokeRepeating("SpawnLeftAnimal", startDelayLeft, spawnInterval);
        //InvokeRepeating("SpawnRightAnimal", startDelayRight, spawnInterval);
    }//start

    // Update is called once per frame
    void Update()
    {

    }//update

    //method to spawn a random animal in a random location along the 
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }//SpawnRandomAnimal

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
