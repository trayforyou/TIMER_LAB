using TMPro;
using UnityEngine;

public class TimerViewer : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private TextMeshProUGUI _timerText;

    private void OnEnable()
    {
        _timer.NumberChanged += ChangeTextNumber;
    }

    private void OnDisable()
    {
        _timer.NumberChanged -= ChangeTextNumber;
    }

    private void ChangeTextNumber()
    {
        _timerText.text = _timer.CurrentNumber.ToString("");
    }
}