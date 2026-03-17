using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectionArrivee : MonoBehaviour
{
    public Chronometre chrono;
    public string menuSceneName = "Menu";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (chrono != null)
            {
                chrono.StopChrono();
                float tempsFinal = chrono.TempsFinal;

                PlayerPrefs.SetFloat("TempsFinal", tempsFinal);
                PlayerPrefs.Save();
            }

            StartCoroutine(RevenirAuMenu());
        }
    }

    private System.Collections.IEnumerator RevenirAuMenu()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(menuSceneName);
    }
}