using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayScript : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
