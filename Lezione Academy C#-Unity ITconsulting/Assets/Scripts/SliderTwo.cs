using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderTwo : MonoBehaviour
{
    [SerializeField] private Slider _sliderTwo;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Light _light;

    private void Start()
    {
        // Imposta listener solo una volta
        _sliderTwo.onValueChanged.AddListener(LightChanged);

        // Inizializza UI e valore di partenza
        LightChanged(_sliderTwo.value);
    }

    private void LightChanged(float value)
    {
        // Aggiorna intensità luce
        _light.intensity = value;

        // Aggiorna testo a schermo
        _text.text = $"Intensità luce: {value:F0}";
    }
}
