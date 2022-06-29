using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpawnPoints))]

public class EnemyRender : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private SpawnPoints _points;

    private void Start()
    {
        _points = GetComponent<SpawnPoints>();
        StartCoroutine(EnemyGeneration());
    }

    private IEnumerator EnemyGeneration()
    {
        var waitForSeconds = new WaitForSeconds(2f);

        foreach (var enemy in _points.Spawn)
        {
            yield return waitForSeconds;
            Instantiate(_enemy, enemy.transform.position, Quaternion.identity);
        }
    }
}