using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Positions))]

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private Positions _positions;

    private void Start()
    {
        _positions = GetComponent<Positions>();
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        var waitForSeconds = new WaitForSeconds(2f);

        foreach (var enemy in _positions.Spawn)
        {
            yield return waitForSeconds;
            Instantiate(_enemy, enemy.transform.position, Quaternion.identity);
        }
    }
}
