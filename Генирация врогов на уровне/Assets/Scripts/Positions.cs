using UnityEngine;

public class Positions : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPositions;

    public GameObject[] Spawn => _spawnPositions;
}
