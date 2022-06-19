using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPositions;

    public GameObject[] Spawn => _spawnPositions;
}
