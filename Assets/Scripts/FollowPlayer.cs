using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    
    void Update()
    {
        // Lætur myndavélina vera á sérstakri staðsetningu og færir 
        // hana útaf uppfærslu
        transform.position = Player.position + offset;
    }
}
