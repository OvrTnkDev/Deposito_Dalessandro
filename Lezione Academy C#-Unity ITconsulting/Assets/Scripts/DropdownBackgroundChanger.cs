using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownBackgroundChanger : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _dropdown;     // il dropdown
    [SerializeField] private Image _backgroundImage;     // lo sfondo da cambiare
    [SerializeField] private List<Sprite> _backgrounds;  // lista di sfondi impostabili da Inspector

    private void Start()
    {
        // Popola dinamicamente le opzioni del dropdown
        _dropdown.ClearOptions();
        List<string> options = new List<string>();

        for (int i = 0; i < _backgrounds.Count; i++)
            options.Add($"Personaggio {i + 1}");

        _dropdown.AddOptions(options);

        // Listener per cambio sfondo
        _dropdown.onValueChanged.AddListener(OnDropdownChanged);

        // Imposta sfondo iniziale
        if (_backgrounds.Count > 0)
            OnDropdownChanged(0);
    }

    private void OnDropdownChanged(int index)
    {
        if (index >= 0 && index < _backgrounds.Count)
        {
            _backgroundImage.sprite = _backgrounds[index];
            Debug.Log($"Personaggio cambiato: {_backgrounds[index].name}");
        }
    }
}
