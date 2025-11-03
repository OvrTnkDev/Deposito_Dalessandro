using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputControl : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputFieldOne;
    [SerializeField] private TMP_InputField _inputFieldTwo;
    [SerializeField] private TMP_InputField _inputFieldThree;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Button _button;

    private Color normalColor = Color.green;
    private Color errorColor = new Color(1f, 0.6f, 0.6f);

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        bool hasError = false;
        string errorMessage = "";

        // Controllo campo 1
        if (string.IsNullOrWhiteSpace(_inputFieldOne.text))
        {
            hasError = true;
            errorMessage += "Il campo 1 è vuoto.\n";
            SetInputColor(_inputFieldOne, errorColor);
        }
        else SetInputColor(_inputFieldOne, normalColor);

        // Controllo campo 2
        if (string.IsNullOrWhiteSpace(_inputFieldTwo.text))
        {
            hasError = true;
            errorMessage += "Il campo 2 è vuoto.\n";
            SetInputColor(_inputFieldTwo, errorColor);
        }
        else SetInputColor(_inputFieldTwo, normalColor);

        // Controllo campo 3
        if (string.IsNullOrWhiteSpace(_inputFieldThree.text))
        {
            hasError = true;
            errorMessage += "Il campo 3 è vuoto.\n";
            SetInputColor(_inputFieldThree, errorColor);
        }
        else SetInputColor(_inputFieldThree, normalColor);

        // Mostra messaggio
        if (hasError)
        {
            _text.color = Color.red;
            _text.text = $"Correggi i seguenti errori:\n{errorMessage}";
        }
        else
        {
            _text.color = Color.green;
            _text.text = "Tutti i campi sono compilati correttamente!";
        }
    }

    private void SetInputColor(TMP_InputField inputField, Color color)
    {
        var image = inputField.GetComponent<Image>();
        if (image != null)
            image.color = color;
    }
}
