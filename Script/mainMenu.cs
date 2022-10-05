using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void firstStage()
    {
        Ball.ballRemain = 3;
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene("Mainlevel");
    }

    public void secondStage()
    {
        Ball.ballRemain = 3;
        Enemy.EnemiesAlive = 0;
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
        Ball.ballRemain = 3;
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
