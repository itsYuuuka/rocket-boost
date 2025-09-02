using UnityEngine;
using UnityEngine.InputSystem;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        CloseGame();
    }
    
    private void CloseGame()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("Game is exiting");
            Application.Quit();
        }
    }
}
