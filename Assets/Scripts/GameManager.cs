using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    // Gerir tímann fyrir biðin fyrir restartið
    public float restartDelay = 0.2f;

    public GameObject completeLevelUI;

    public GameObject failedLevelUI;

    public void CompleteLevel()
    {
        // Athugar hvort þú komst að endanum
        completeLevelUI.SetActive(true);
    }

    public void FailedLevel()
    {
        // Athugar hvort þú tapaðir
        failedLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            FailedLevel();
            // Setur bið á restartið
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        // Byrjar aftur sceneið
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
