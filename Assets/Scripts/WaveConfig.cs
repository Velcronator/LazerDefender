using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enermy Wave Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enermyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemiesInWave = 5;
    [SerializeField] float moveSpeed = 2f;

    public GameObject GetEnermyPrefab() { return enermyPrefab; }
    public List<Transform> GetWaypoints()
    {
        var waveWaypoints = new List<Transform>();
        foreach(Transform pathPrefabChild in pathPrefab.transform)
        {   // for each transform of the pathPrefab get the waypoints which are children
            waveWaypoints.Add(pathPrefabChild);
        }
        return waveWaypoints;
    }
    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; }
    public float GetSpawnRandomFactor() { return spawnRandomFactor; }
    public int GetNumberOfEnemiesInWave() { return numberOfEnemiesInWave; }
    public float GetMoveSpeed() { return moveSpeed; }
}
