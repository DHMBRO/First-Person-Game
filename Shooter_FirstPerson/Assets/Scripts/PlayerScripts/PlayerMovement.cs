using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speedWalk = 1.0f;
    [SerializeField] float _speedRun = 3.0f;

    float _currentSpeed;
    float _speedHorizontal;
    float _speedVertical;
    
    public void MovePlayer()
    {
        _speedHorizontal = Input.GetAxis("Horizontal");
        _speedVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _currentSpeed = _speedRun;
        }
        else _currentSpeed = _speedWalk;


        transform.position += (transform.forward * (_speedVertical * _currentSpeed)) * Time.deltaTime;
        transform.position += (transform.right * (_speedHorizontal * _currentSpeed)) * Time.deltaTime;
    }

}
