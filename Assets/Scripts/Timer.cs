using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timeStep = 0.5f;

    private int _currentNumber;
    private bool _isActive = false;

    public int CurrentNumber => _currentNumber;

    public event Action NumberChanged;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isActive = !_isActive;

            if (_isActive)
            {
                StartCoroutine(CounterNumbers(_timeStep));
            }
            else
            {
                StopAllCoroutines();
            }
        }
    }

    private IEnumerator CounterNumbers(float timeStep)
    {
        var wait = new WaitForSeconds(timeStep);

        while (true)
        {
            _currentNumber++;

            NumberChanged.Invoke();

            yield return wait;
        }
    }
}