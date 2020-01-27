using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame ()
    {
        // Finnur í Build settings hvaða scene þú ert á og sendir þig á næstu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
