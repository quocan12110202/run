using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundtile : MonoBehaviour
{
    public GameObject RaoChan;
    public GameObject Coin;
    private void Start()
    {
        SpawnRaoChan();
        SpawnCoin();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            GroundSpawner.Instance.SpawnTile();
            Destroy(gameObject,2);
        }
    }
    void SpawnRaoChan()
    {
        int raoChanChiMuc=Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(raoChanChiMuc).transform;
        Instantiate(RaoChan, spawnPoint.position, Quaternion.identity, transform);
    }
    void SpawnCoin()
    {
        GameObject temp = Instantiate(Coin, transform);
        temp.transform.position = RandomPos(GetComponent<Collider>());

    }
    Vector3 RandomPos(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z));
        if(point!=collider.ClosestPoint(point))
        {
            point=RandomPos(collider);
        }
        point.y = 1;
        return point;
    }
}
