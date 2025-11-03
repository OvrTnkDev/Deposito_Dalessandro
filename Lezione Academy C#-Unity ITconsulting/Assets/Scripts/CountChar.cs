using UnityEngine;
using TMPro;

public class CountChar : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _inputField.onValueChanged.AddListener(OnInputChanged);
    }

    private void OnDisable()
    {
        _inputField.onValueChanged.RemoveListener(OnInputChanged);
    }

    private void OnInputChanged(string input)
    {
        // Se l'input non è convertibile in numero, non mostra errori
        if (int.TryParse(input, out int value))
        {
            if (value > 100)
            {
                _text.text = $"Il numero inserito ({value}) è maggiore di 100";
            }
            else
            {
                _text.text = $"Il numero inserito ({value}) è minore o uguale a 100";
            }
        }
        else if (string.IsNullOrEmpty(input))
        {
            _text.text = "Inserisci un numero...";
        }
    }
}
