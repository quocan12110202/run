using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public static GroundSpawner Instance;
    private Vector3 nextSpawmpoint;
    public GameObject groundTile;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        for(int i = 0; i< 30;i++)
        {
            SpawnTile();
        }
    }
    public void SpawnTile()
    {
        GameObject temp=Instantiate(groundTile, nextSpawmpoint, Quaternion.identity);
        nextSpawmpoint = temp.transform.GetChild(1).position;
    }

}
