using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControll : MonoBehaviour
{
    public Text playerText;
    
    
    // public GameObject star3;
    // public GameObject star2;
    // public GameObject star1;

    // private void Start()
    // {
    //     star3 = GameObject.Find("/Buttons/winDisplay3");
    //     star2 = GameObject.Find("/Buttons/winDisplay2");
    //     star1 = GameObject.Find("/Buttons/winDisplay1");
    // }
    
    // Update is called once per frame
    public void Update()
    {
        playerText.text = Ball.ballRemain.ToString();
    }

    // public void winLevel()
    // {
    //     if (stars == 2)
    //         star3.SetActive(true);
    //     else if (stars == 1)
    //         star2.SetActive(true);
    //     else if (stars == 0)
    //         star1.SetActive(true);
    // }

    public void nextStage()
    {
        SceneManager.LoadScene("SecondLevel");
    }

    public void retryStage()
    {
        Ball.ballRemain = 3;
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
