using UnityEngine;

public class IKTest : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private AvatarIKGoal _avatarIKGoal;
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private Transform _limb;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnAnimatorIK()
    {
        _animator.SetIKPositionWeight(_avatarIKGoal, 1.0f);
        _animator.SetIKRotationWeight(_avatarIKGoal, 1.0f);

        _animator.SetIKPosition(_avatarIKGoal, _limb.position);
        _animator.SetIKRotation(_avatarIKGoal, _limb.rotation);

    }
}
