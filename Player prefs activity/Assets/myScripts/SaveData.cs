using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaveData : MonoBehaviour
{
    public InputField textBox;

    public void ClickSave()
    {
        PlayerPrefs.SetString("username", textBox.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
