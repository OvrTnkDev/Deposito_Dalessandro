using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleTwo : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _text;

    public bool IsOn => _toggle.isOn;
    private void Start()
    {
        _toggle.onValueChanged.AddListener(ToggleEn);
        ToggleEn(_toggle.isOn);
    }

    private void ToggleEn(bool isOn)
    {
        _image.enabled = isOn;
        _text.text = isOn ? "Immagine Attiva" : "Immagine Nascosta";
    }
}