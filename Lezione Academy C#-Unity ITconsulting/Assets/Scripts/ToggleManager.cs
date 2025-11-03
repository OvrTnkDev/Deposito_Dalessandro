using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleManager : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    [SerializeField] private ToggleOne toggleObjScript;
    [SerializeField] private ToggleTwo toggleImgScript;
    [SerializeField] private TextMeshProUGUI _text;
    public bool IsOn => _toggle.isOn;
    public bool IsObjectActive() => toggleObjScript.IsOn;
    public bool IsImageActive()  => toggleImgScript.IsOn;

    private void Start()
    {
        _toggle.onValueChanged.AddListener(ToggleEn);

        ToggleEn(_toggle.isOn);
    }

    private void ToggleEn(bool isOn)
    {
        _text.enabled = isOn;
    }
    
    private void Update()
    {
        _text.text = $"Oggetto 3D: {(IsObjectActive() ? "Attivo" : "Disattivo")}, Immagine: {(IsImageActive() ? "Attiva" : "Disattiva")}";
    }
}
