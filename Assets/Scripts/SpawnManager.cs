using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] animalPrefabs;
    private float spawnPosition;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawnPosition = Random.Range(-20.0f, 20.0f);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(spawnPosition, 0,30), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
