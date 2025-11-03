using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleOne : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    [SerializeField] private Transform _obj;
    [SerializeField] private TextMeshProUGUI _text;

    public bool IsOn => _toggle.isOn;
    private void Start()
    {
        _toggle.onValueChanged.AddListener(ToggleEn);
        ToggleEn(_toggle.isOn);
    }

    private void ToggleEn(bool isOn)
    {
        _obj.gameObject.SetActive(isOn);
        _text.text = isOn ? "Oggetto Attivo" : "Oggetto Disattivato";
    }
}