using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void SetSpeedX(float speedX)
    {
        _animator.SetFloat(ConstantsData.AnimatorParameters.SpeedX, Mathf.Abs(speedX));
    }

    public void SetBoolJump(bool isJump)
    {
        _animator.SetBool(ConstantsData.AnimatorParameters.Jump, isJump);
    }
}
