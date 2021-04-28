﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform playerOne;
    public Transform respawnPointOne;

    public Transform playerTwo;
    public Transform respawnPointTwo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
        {
            playerOne.transform.position = respawnPointOne.transform.position;
            Physics.SyncTransforms();
        }

        if (other.CompareTag("PlayerTwo"))
        {
            playerTwo.transform.position = respawnPointTwo.transform.position;
            Physics.SyncTransforms();
        }
    }

}
