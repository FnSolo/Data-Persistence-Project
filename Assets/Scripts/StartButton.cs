using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Text Name;

    public InputField EnterName;

    private void Start()
    {
        EnterName.text = PlayerPrefs.GetString("name");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("main");
    }

    public void SaveName()
    {
        PlayerPrefs.SetString("name", Name.text);
    }
}
