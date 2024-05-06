using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] bool _nowIsWork;

    PlayerReference _playerReference;
    PlayerMovement _playerMovement;
    
    void Start()
    {
        _playerReference = GetComponent<PlayerReference>();
        _playerMovement = GetComponent<PlayerMovement>(); 

        _nowIsWork = false;
    }

    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            _nowIsWork = true;
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None; 
            _nowIsWork = false; 
        }

        if (!_nowIsWork)
        {
            return;
        }

        _playerMovement.MovePlayer();
        _playerReference.ReturnPlayerCamera().RotatePlayer();

    }
}
