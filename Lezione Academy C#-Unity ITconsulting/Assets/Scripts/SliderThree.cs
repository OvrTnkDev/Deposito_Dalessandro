using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderThree : MonoBehaviour
{
    [SerializeField] private Button _toggleButton;
    [SerializeField] private Button _resetButton;
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Transform _targetObject;

    private Vector3 _originalScale;
    private bool _sliderEnabled = true;

    private void Start()
    {
        // Salva la scala originale
        _originalScale = _targetObject.localScale;

        // Aggiungi listener UNA volta
        _slider.onValueChanged.AddListener(ChangeScale);
        _toggleButton.onClick.AddListener(ToggleSlider);
        _resetButton.onClick.AddListener(ResetScale);

        // Inizializza UI
        ChangeScale(_slider.value);
    }

    private void ChangeScale(float value)
    {
        if (!_sliderEnabled) return;

        _targetObject.localScale = new Vector3(value, value, value);
        _text.text = $"Scala: {value:F1}";
    }

    private void ToggleSlider()
    {
        _sliderEnabled = !_sliderEnabled;
        _slider.interactable = _sliderEnabled;
        _toggleButton.GetComponentInChildren<TextMeshProUGUI>().text = _sliderEnabled ? "Disattiva" : "Attiva";
    }

    private void ResetScale()
    {
        _targetObject.localScale = _originalScale;
        _slider.value = 1f;
        _text.text = "Scala: 1.0";
    }
}
