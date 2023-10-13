using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public Text BestScoreText;
    private void Start()
    {
        BestScoreText.text = PlayerPrefs.GetString("BestScore", "Best Score : : 0");
    }
}
