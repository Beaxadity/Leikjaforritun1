using UnityEngine;

public class EnsTrigger : MonoBehaviour
{
    // gerir managerinn
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        // lætur borðið klárast þegar þetta er triggerað
        gameManager.CompleteLevel();
    }
}
