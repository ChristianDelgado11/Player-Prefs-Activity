using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if(isGameOver == false)
        {
            isGameOver = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
