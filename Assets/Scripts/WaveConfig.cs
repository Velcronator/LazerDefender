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
    public GameObject GetPathPrefab() { return pathPrefab; }
    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; }
    public float GetSpawnRandomFactor() { return spawnRandomFactor; }
    public int GetNumberOfEnemiesInWave() { return numberOfEnemiesInWave; }
    public float GetMoveSpeed() { return moveSpeed; }
}
