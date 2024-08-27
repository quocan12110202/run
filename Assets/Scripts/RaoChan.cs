using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaoChan : MonoBehaviour
{
    player player;
    private void Awake()
    {
        player = GameObject.FindObjectOfType<player>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.Die();
        }
    }

}
