using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit ()
    {
        // Segir í Console þegar er verið aðloka leiknum
        Debug.Log("Quit");
        // lokar leiknum
        Application.Quit();
    }
}
