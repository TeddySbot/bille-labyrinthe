using UnityEngine;
using UnityEngine.UI;

public class Chronometre : MonoBehaviour
{
    public Text chronoText; 

    private float temps = 0f;
    private bool enCours = true;

    public float TempsFinal { get; private set; }


    void Update()
    {
        if (!enCours) return;

        temps += Time.deltaTime;
        AfficherTemps();
    }

    void AfficherTemps()
    {
        int minutes = Mathf.FloorToInt(temps / 60f);
        int secondes = Mathf.FloorToInt(temps % 60f);

        chronoText.text = "Temps : " + minutes.ToString("00") + ":" + secondes.ToString("00");
    }

    public void StopChrono()
    {
        TempsFinal = temps;
        enCours = false;
    }
}