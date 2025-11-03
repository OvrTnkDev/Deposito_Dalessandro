using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderOne : MonoBehaviour
{
    [SerializeField] private Slider _sliderOne;
    [SerializeField] private TextMeshProUGUI _text;
    private void Start() 
    {
        _sliderOne.onValueChanged.AddListener(Volume);
    }
    public void Volume(float v) =>  _text.text = $"Volume: {v:f1}";
}
