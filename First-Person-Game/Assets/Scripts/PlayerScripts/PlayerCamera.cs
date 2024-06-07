using UnityEngine;

public class PlayerCamera : MonoBehaviour, ICheckToRepairParameters
{
    [SerializeField] private float _sensitivity = 100.0f;

    private PlayerControler _playerControler;


    private void Start()
    {
        _playerControler = GetComponentInParent<PlayerControler>();
        transform.forward = new Vector3(0.0f, 0.0f, 0.0f);

        if (!_playerControler) Debug.Log("Not set _playerBody !");
    }


    public void Realization()
    {
        _playerControler.transform.eulerAngles += new Vector3(0.0f, ReturnProduct(_playerControler.ReturnMouseX()), 0.0f);

        transform.localEulerAngles += new Vector3(-ReturnProduct(_playerControler.ReturnMouseY()), 0.0f, 0.0f);

        CheckToRepairParameters();
    }

    public bool CheckToRepairParameters()
    {
        if(transform.localEulerAngles.x < -90.0f || transform.localEulerAngles.x > 90.0f)
        {
            Repair();
            Debug.Log("Call Repair!");
            return true;
        } 
        else return false;

    }

    private void Repair()
    {
        transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
    }


    private float ReturnProduct(float inputParametr)
    {
        return inputParametr = inputParametr * _sensitivity * Time.deltaTime;
    }



}
