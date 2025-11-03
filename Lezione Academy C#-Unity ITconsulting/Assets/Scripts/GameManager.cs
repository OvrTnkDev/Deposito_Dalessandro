using System.Threading;
using System.Linq;
using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    // [SerializeField] private int _score = 0;

    private bool _startTimer = false;
    [SerializeField] private float _timer = 0;
    [SerializeField] private List<float> _lastTime = new List<float>();
    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private TextMeshProUGUI _timerTop;
    [SerializeField] private TextMeshProUGUI _congratulation;

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    void Update()
    {
        if (_startTimer)
        {
            _timer += Time.deltaTime;
            _timerText.text = $"Timer: {_timer:F2}";
            _timerTop.text = $"Top Timer: {TopScore():f2}";
        }
    }

    // public int IncrementaScore(int amount)
    // {
    //     _score += amount;
    //     return _score;
    // }

    public void StartTimer()
    {
        _startTimer = true;
    }

    public void StopTimer()
    {
        _startTimer = false;
        _lastTime.Add(_timer);
        _timer = 0;
        Congratulation();
    }
    public float TopScore()
    {
        return _lastTime.Min();
    }

    public bool IsTimerStarted()
    {
        return _startTimer;
    }
    public void Congratulation()
    {
        StartCoroutine(ShowCongratulation(3f));
    }

    private IEnumerator ShowCongratulation(float duration)
    {
        if (_congratulation != null)
        {
            _congratulation.text = "Congratulazioni, hai terminato il percorso!";
            _congratulation.gameObject.SetActive(true); // assicurati che sia visibile
        }

        yield return new WaitForSeconds(duration);

        if (_congratulation != null)
        {
            _congratulation.text = "";
            _congratulation.gameObject.SetActive(false); // opzionale: nasconde l'oggetto
        }
    }
}
