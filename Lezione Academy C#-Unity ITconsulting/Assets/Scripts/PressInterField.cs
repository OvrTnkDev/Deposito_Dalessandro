using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PressInterField : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerClickHandler
{
    [SerializeField] private Image _image;

    public void OnPointerDown(PointerEventData eventData)
    {
        print($"Puntatore premuto sull'oggetto -> tramite Interfaccia!");
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Clic sinistro rilevato");
            Debug.Log($"Numero di clic sinistro: {eventData.clickCount}");
            if(eventData.clickCount < 1)
            {
                Debug.Log("Multi clic sinistro rilevato!");
                _image.color = new Color(Random.value, Random.value, Random.value);
            }
        }
        else
        {
            Debug.Log("Clic destro rilevato");
            Debug.Log($"Numero di clic destro: {eventData.clickCount}");
            if(eventData.clickCount < 1)
            {
                Debug.Log("Multi clic destro rilevato!");
                _image.color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print($"Puntatore rilasciato sull'oggetto -> tramite Interfaccia!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print($"L'oggetto è stato cliccato -> tramite Interfaccia!");
    }
}
