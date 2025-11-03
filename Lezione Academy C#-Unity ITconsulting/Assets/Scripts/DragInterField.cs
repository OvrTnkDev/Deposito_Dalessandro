using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragInterField : MonoBehaviour,
    IBeginDragHandler,
    IDragHandler,
    IEndDragHandler,
    ISelectHandler,
    IDeselectHandler,
    IPointerDownHandler
{
    [SerializeField] private Image _image;
    private Color _originalColor;

    private void Start()
    {
        if (_image == null)
            _image = GetComponent<Image>();

        _originalColor = _image.color;
    }

    // 🔹 Quando comincia il drag
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("Inizio drag...");
    }

    // 🔹 Durante il drag
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    // 🔹 Quando finisce il drag
    public void OnEndDrag(PointerEventData eventData)
    {
        print("Fine drag.");
    }

    public void OnSelect(BaseEventData eventData)
    {
        _image.color = new Color(Random.value, Random.value, Random.value);
        print("Oggetto selezionato!");
    }

    public void OnDeselect(BaseEventData eventData)
    {
        _image.color = _originalColor;
        print("Oggetto deselezionato!");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        print($"Puntatore premuto sull'oggetto -> {_image.name}!");
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Clic sinistro rilevato");
            Debug.Log($"Numero di clic sinistro: {eventData.clickCount}");
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Clic destro rilevato");
            Debug.Log($"Numero di clic destro: {eventData.clickCount}");
        }
    }
}
