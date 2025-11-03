using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _dropdown;
    [SerializeField] private Image _imageOne;
    [SerializeField] private Image _imageTwo;
    [SerializeField] private Image _imageThree;
    [SerializeField] private TextMeshProUGUI _text1;

    private void OnEnable()
    {
        // Aggiunge il listener all’evento del dropdown
        _dropdown.onValueChanged.AddListener(DdIndex);

        // Aggiorna lo stato iniziale
        DdIndex(_dropdown.value);
    }

    private void OnDisable()
    {
        // Rimuove il listener per evitare memory leak
        _dropdown.onValueChanged.RemoveListener(DdIndex);
    }

    private void DdIndex(int index)
    {
        // Disattiva tutte le immagini prima di attivare quella selezionata
        _imageOne.gameObject.SetActive(false);
        _imageTwo.gameObject.SetActive(false);
        _imageThree.gameObject.SetActive(false);

        // Attiva solo quella corrispondente all'indice selezionato
        switch (index)
        {
            case 0:
                _imageOne.gameObject.SetActive(true);
                _text1.text = $"FACILE!";
                break;
            case 1:
                _imageTwo.gameObject.SetActive(true);
                _text1.text = $"DIFFACILE!!";
                break;
            case 2:
                _imageThree.gameObject.SetActive(true);
                _text1.text = $"DIFFICILE!!!";
                break;
        }
    }
}
