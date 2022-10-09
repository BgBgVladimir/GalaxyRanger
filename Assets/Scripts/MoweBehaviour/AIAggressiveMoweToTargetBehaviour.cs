using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Mowe/AIAggressiveMoweToTargetBehaviour")]
public class AIAggressiveMoweToTargetBehaviour: MoweBehaviour
{
    private Vector2 _moweVector;

    [SerializeField] private Transform _target;
    public override void Init(Rigidbody2D rigidbody2D)
    {
        _rigidBody2D = rigidbody2D;
    }
    public override void Mowe()
    {
        if(_target==null)
        {
            return;
        }
        _moweVector =_target.position-_rigidBody2D.transform.position;
        _rigidBody2D.AddForce(_moweVector.normalized*moweSpeed);
    }
    public override void SetTarget(Transform target)
    {
        _target=target;
    }
}
