using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InteractionField : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _enterColor = Color.green;
    [SerializeField] private Color _exitColor = Color.white;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _image.color = _enterColor;
        print($"Il colore dell'immagine è {_enterColor}");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.color = _exitColor;
        print($"Il colore dell'immagine è {_exitColor}");
    }
}
