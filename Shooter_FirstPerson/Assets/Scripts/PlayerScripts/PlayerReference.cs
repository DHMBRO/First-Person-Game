using UnityEngine;

public class PlayerReference : MonoBehaviour
{
    PlayerControler _playerControler;
    CanvasControler _canvasControler;
    
    PlayerCamera _playerCamera;


    void Start()
    {
        _playerControler = GetComponent<PlayerControler>();
        _playerCamera = GetComponentInChildren<PlayerCamera>();

        _canvasControler = GetComponent<CanvasControler>();
    }
    
    public PlayerCamera ReturnPlayerCamera()
    {
        PlayerCamera _localCamera = _playerCamera;
        return _localCamera;
    }

}
