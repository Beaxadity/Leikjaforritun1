using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        // 1X Athugar hvort leikmaðurinn klessti á "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //Endar leikinn ef svo 1X
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}