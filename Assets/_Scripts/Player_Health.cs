using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class Player_Health : MonoBehaviour
{
    public Image healthBar;
    public float playerHealth;
    public float currentHealth;
    public Player_Controller player;
    public CinemachineVirtualCamera cam;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = playerHealth;
    }

    public void TakeDMG(float damage)
    {

        currentHealth -= damage;
        healthBar.fillAmount = currentHealth / playerHealth;
        if(currentHealth<=0)
        {
            cam.enabled = false;
            player.gameover = true;
            player.PlayerDead();
        }
    }
}
