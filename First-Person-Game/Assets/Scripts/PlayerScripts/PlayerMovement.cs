using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _walkSpeed = 1.34f;
    [SerializeField] private float _runSpeed = 5.0f;

    private PlayerControler _controlerPlayer;
    private Vector3 _direction;
    private float _currentSpeed;

    private void Start()
    {
        _controlerPlayer = GetComponent<PlayerControler>();
    }
    
    public void Realization()
    {
        switch (_controlerPlayer.ReturnSpeedLegsAre())
        {
            case SpeedLegsAre.Staying:
                _currentSpeed = 0.0f;
                break;
            case SpeedLegsAre.Walking:
                _currentSpeed = _walkSpeed;
                break;
            case SpeedLegsAre.Runing:
                _currentSpeed = _runSpeed;
                break;
        }

        _direction = new Vector3(_controlerPlayer.ReturnHorizontal(), 0.0f, _controlerPlayer.ReturnVertical()) * _currentSpeed;
        
        if(_controlerPlayer.ReturnHorizontal() != 0.0f && _controlerPlayer.ReturnVertical() != 0.0f)
        {
            _direction /= 1.4f; 
        }


        transform.position += (transform.forward * _direction.z) * Time.deltaTime;
        transform.position += (transform.right * _direction.x) * Time.deltaTime;

    }

    private float ReturnProduct(float currentSpeed)
    {
        return currentSpeed *= Time.deltaTime;
    }

}
