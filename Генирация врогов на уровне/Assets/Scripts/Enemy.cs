using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("Insert a prefab with an enemy to generate")]
    [SerializeField] private GameObject _enemy;

    public GameObject Object => _enemy;
}
