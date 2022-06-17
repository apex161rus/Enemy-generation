using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PositionsSpawn))]

public class PositionsSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private GameObject[] _spawnPositions;

    private void Start()
    {
        _spawnPositions = GameObject.FindGameObjectsWithTag("Spawn");
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        var waitForSeconds = new WaitForSeconds(2f);

        foreach (var enemy in _spawnPositions)
        {
            yield return waitForSeconds;
            Instantiate(_gameObject, enemy.transform.position, Quaternion.identity);
        }
    }
}
