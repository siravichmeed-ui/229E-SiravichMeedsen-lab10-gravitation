using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Slider speedSlider;
    public TextMeshProUGUI speedText;

    void Start()
    {
        speedSlider.onValueChanged.AddListener(UpdateSpeed);
        UpdateSpeed(speedSlider.value);
    }

    public void UpdateSpeed(float value)
    {
        Time.timeScale = value;
        speedText.text = "Speed: x" + value.ToString("0");
    }

    public void SetSpeed(float value)
    {
        speedSlider.value = value;
        UpdateSpeed(value);
    }
}
