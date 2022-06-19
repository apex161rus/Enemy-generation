using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpawnPoint))]

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private SpawnPoint _positions;

    private void Start()
    {
        _positions = GetComponent<SpawnPoint>();
        StartCoroutine(EnemyGeneration());
    }

    private IEnumerator EnemyGeneration()
    {
        var waitForSeconds = new WaitForSeconds(2f);

        foreach (var enemy in _positions.Spawn)
        {
            yield return waitForSeconds;
            Instantiate(_enemy, enemy.transform.position, Quaternion.identity);
        }
    }
}