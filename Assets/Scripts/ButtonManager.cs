using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
