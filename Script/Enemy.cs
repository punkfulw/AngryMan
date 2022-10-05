using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject deathEffect;
    public AudioSource audioPlayer;
    public AudioClip SE;

    public float health = 3f;


    public static int EnemiesAlive = 0;

    void Start()
    {
        EnemiesAlive++;
    }



    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        audioPlayer.PlayOneShot(SE);


        --EnemiesAlive;

        Destroy(gameObject);

        //while WIN
        if (EnemiesAlive <= 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                if (Ball.ballRemain == 2)
                {
                    Ball.ballRemain = 3;
                    SceneManager.LoadScene("star3Scene1");
                }   
                else if (Ball.ballRemain == 1)
                {
                    Ball.ballRemain = 3;
                    SceneManager.LoadScene("star2Scene1");
                }
                else if (Ball.ballRemain == 0)
                {
                    Ball.ballRemain = 3;
                    SceneManager.LoadScene("star1Scene1");
                }
            }
            else 
            {
                if (Ball.ballRemain == 2)
                {
                    Ball.ballRemain = 3;
                    SceneManager.LoadScene("star3Scene");
                }   
                else if (Ball.ballRemain == 1)
                {
                    Ball.ballRemain = 3;
                    SceneManager.LoadScene("star2Scene");
                }
                else if (Ball.ballRemain == 0)
                {
                    Ball.ballRemain = 3;
                    SceneManager.LoadScene("star1Scene");
                }
            }
            
        }

        
    }
}
