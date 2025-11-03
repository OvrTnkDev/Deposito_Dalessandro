using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button _buttonIncrement;
    [SerializeField] private Button _buttonDecrement;
    [SerializeField] private Button _buttonHello;
    [SerializeField] private int _n = 0;
    [SerializeField] private int _n2 = 0;
    [SerializeField] private TextMeshProUGUI _text;
    

    private void OnEnable()
    {
        _buttonIncrement.onClick.AddListener(() => Plus());
        _buttonDecrement.onClick.AddListener(() => Meno());
        _buttonHello.onClick.AddListener(() => Hello());
    }

    private void OnDisable()
    {
        _buttonIncrement.onClick.RemoveListener(() => Plus());
        _buttonDecrement.onClick.RemoveListener(() => Meno());
        _buttonHello.onClick.AddListener(() => Hello());
    }

    public void Plus() =>  _text.text = $"{++_n}";
    public void Meno() =>  _text.text = $"{--_n}";
    public void Hello() => _text.text = $"Riclicca {++_n2 * 2}";
}
