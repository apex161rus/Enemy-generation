using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpawnPoints))]
[RequireComponent(typeof(Enemy))]

public class EnemySpawner : MonoBehaviour
{
    private Enemy _еnemy;
    private SpawnPoints _points;

    private void Start()
    {
        _points = GetComponent<SpawnPoints>();
        _object = GetComponent<Enemy>();
        StartCoroutine(EnemyGeneration());
    }

    private IEnumerator EnemyGeneration()
    {
        var waitForSeconds = new WaitForSeconds(2f);

        foreach (var enemy in _points.Spawn)
        {
            yield return waitForSeconds;
            Instantiate(_еnemy.Object, enemy.transform.position, Quaternion.identity);
        }
    }
}
