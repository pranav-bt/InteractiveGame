using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> Spawners;
    public GameObject Hazard;
    public float SpawnIntervalMin = 1.0f;
    public float SpawnIntervalMax = 1.5f;
    int MaxList;
    float CurrentSpawnInterval;
    private float CurrentTime = 0.0f;
    private float TimeElapsed = 0.0f;
    void Start()
    {
        MaxList = Spawners.Count;
        CurrentSpawnInterval = Random.Range(SpawnIntervalMin, SpawnIntervalMax);
    }

    // Update is called once per frame
    void Update()
    {
        TimeElapsed += Time.deltaTime;
        if (TimeElapsed - CurrentTime > CurrentSpawnInterval)
        { 
            int CurrentSpawner = Random.Range(0, MaxList - 1);
            GameObject NewHazard = Instantiate(Hazard, Spawners[CurrentSpawner].gameObject.transform) as GameObject;
            CurrentTime = TimeElapsed;
            CurrentSpawnInterval = Random.Range(SpawnIntervalMin, SpawnIntervalMax);
        }
    }
}
