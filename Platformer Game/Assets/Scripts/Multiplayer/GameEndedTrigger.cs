using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndedTrigger : MonoBehaviour
{
    public GameManager managerGame;

    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
        {
            managerGame.managerUI.playerOneEndingTrigger();
        }

        if (other.CompareTag("PlayerTwo"))
        {
            managerGame.managerUI.playerTwoEndingTrigger();
        }
    }
}
