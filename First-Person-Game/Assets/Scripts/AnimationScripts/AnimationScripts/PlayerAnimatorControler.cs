using UnityEngine;

public class PlayerAnimatorControler : MonoBehaviour
{
    private Animator _animatorControlerPLayer;
    private PlayerInverseKinematicControler _inverseKinematicControlerPlayer;

    private PlayerControler _controlerPlayer;

    void Start()
    {
        _animatorControlerPLayer = GetComponent<Animator>();
        _inverseKinematicControlerPlayer = GetComponent<PlayerInverseKinematicControler>();
        _controlerPlayer = GetComponentInParent<PlayerControler>();

        if (!_animatorControlerPLayer) Debug.Log("Not set _animatorControlerPLayer !");
        if (!_inverseKinematicControlerPlayer) Debug.Log("Not set _inverseKinematicControlerPlayer !");
        if (!_controlerPlayer) Debug.Log("Not set _controlerPlayer !");
    }

    void Update()
    {
        if (!_animatorControlerPLayer || !_controlerPlayer)
        {
            return;
        }

         

    }
}
