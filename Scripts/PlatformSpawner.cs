using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private Transform _target;
    public GameObject platformPrefab;
    private Vector3 SpawnerPosition = new Vector3(0, -4, 0);
    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            SpawnerPosition.x = Random.Range(-8f, 8f);
            SpawnerPosition.y += Random.Range(1f, 2f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }
}
