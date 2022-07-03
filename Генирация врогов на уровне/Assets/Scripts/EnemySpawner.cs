using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpawnPoints))]

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private SpawnPoints _points;

    private void Start()
    {
        _points = GetComponent<SpawnPoints>();
        StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        var waitForSeconds = new WaitForSeconds(2f);

        foreach (var enemy in _points.Spawn)
        {
            yield return waitForSeconds;
            Instantiate(_enemy, enemy.transform.position, Quaternion.identity);
        }
    }
}