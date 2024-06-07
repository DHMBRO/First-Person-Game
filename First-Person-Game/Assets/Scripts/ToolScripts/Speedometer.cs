using UnityEngine;

public class Speedometer : MonoBehaviour
{
    [SerializeField] private float _delay = 1.0f;
    [SerializeField] private float _speedMeters = 0.0f;

    private Vector3 _lastSavedPosition;
    private float _calculTime;

    
    void Update()
    {
        if (Time.time >= _calculTime)
        {
            _calculTime = Time.time + _delay;
            
            _speedMeters = (transform.position - _lastSavedPosition).magnitude;
            _lastSavedPosition = transform.position;
        }
    }
}
