using Unity.VisualScripting;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] float _currentSensativity = 1.0f;

    Transform _player;
    float _mouseY;
    float _mouseX;

    void Start()
    {
        _player = transform.parent.GetComponent<Transform>();
    }

    public void RotatePlayer()
    {
        _mouseY = Input.GetAxis("Mouse Y");
        _mouseX = Input.GetAxis("Mouse X");

        transform.localEulerAngles += new Vector3(-_mouseY, 0.0f, 0.0f) * _currentSensativity;
        _player.localEulerAngles += new Vector3(0.0f, _mouseX, 0.0f) * _currentSensativity;
    }

}
