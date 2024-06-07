using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // States
    [SerializeField] private bool _isWorking = false;
    [SerializeField] private SpeedLegsAre _legsSpeedAre = SpeedLegsAre.Staying;
    [SerializeField] private LegsAre _legsAre = LegsAre.Staying;

    // References
    [SerializeField] private PlayerCamera _cameraPlayer;
    [SerializeField] private PlayerMovement _movementPlayer;

    // Parameters
    private float _speedHorizontal;
    private float _speedVertical;

    private float _mouseY;
    private float _mouseX;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        _cameraPlayer = GetComponentInChildren<PlayerCamera>();
        _movementPlayer = GetComponentInChildren<PlayerMovement>();

        if (!_cameraPlayer) Debug.Log("Not set _cameraPlayer !");
        if (!_movementPlayer) Debug.Log("Not set _movementPlayer !");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            _isWorking = false;
            Cursor.lockState  = CursorLockMode.None;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _isWorking = true;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (!_isWorking)
        {
            return;
        }

        // Check Input
        if (_speedHorizontal != 0.0f || _speedVertical != 0.0f)
        {
            _legsSpeedAre = SpeedLegsAre.Walking;
            
            if (Input.GetKey(KeyCode.LeftShift) && _speedVertical >= 0.0f)
            {
                _legsSpeedAre = SpeedLegsAre.Runing;
            }
        }
        else _legsSpeedAre = SpeedLegsAre.Staying;


        
        _speedHorizontal = Input.GetAxis("Horizontal");
        _speedVertical = Input.GetAxis("Vertical");

        _mouseX = Input.GetAxis("Mouse X");
        _mouseY = Input.GetAxis("Mouse Y");

        Debug.Log("Player controler is working !");

        if (_speedHorizontal == -1.0f && _speedVertical == 1.0f)
        {
            Debug.Log((_speedHorizontal + _speedVertical));
        }
            
        _cameraPlayer.Realization();
        _movementPlayer.Realization();
    }

    
    // Return of parameters

    public SpeedLegsAre ReturnSpeedLegsAre()
    {
        return _legsSpeedAre;
    }

    public LegsAre ReturnLegsAre()
    {
        return _legsAre;
    }


    // Return of axis
    public float ReturnHorizontal() 
    {
        return _speedHorizontal;
    }

    public float ReturnVertical()
    {
        return _speedVertical;
    }

    public float ReturnMouseX()
    {
        return _mouseX;
    }

    public float ReturnMouseY()
    {
        return _mouseY;
    }
}
