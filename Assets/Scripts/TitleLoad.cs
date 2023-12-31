using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleLoad : MonoBehaviour
{
    public float timeValue = 10f;
    public TextMeshProUGUI timeText;

    void Update()
    {
        if (timeValue > 0) { timeValue -= Time.deltaTime; }
        else { SceneManager.LoadScene(1); }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        if (seconds >= 0) { timeText.text = seconds.ToString(); }
    }
}
