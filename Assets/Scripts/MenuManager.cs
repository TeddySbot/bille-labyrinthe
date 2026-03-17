using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        float tempsFinal = PlayerPrefs.GetFloat("TempsFinal", 0f);

        int minutes = Mathf.FloorToInt(tempsFinal / 60f);
        int secondes = Mathf.FloorToInt(tempsFinal % 60f);
        int millisecondes = Mathf.FloorToInt((tempsFinal * 1000) % 1000); // partie millisecondes

        scoreText.text = string.Format("Dernier Temps : {0:00}:{1:00}:{2:000}", minutes, secondes, millisecondes);
    }

    public void ChargerGame()
    {
        SceneManager.LoadScene("game");
    }
}