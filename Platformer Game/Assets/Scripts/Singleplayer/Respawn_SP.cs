using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_SP : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }

}