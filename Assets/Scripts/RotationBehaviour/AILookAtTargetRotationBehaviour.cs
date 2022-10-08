using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Rotation/AILookAtTargetRotationBehaviour")]
public class AILookAtTargetRotationBehaviour: RotationBehaviour
{
    [SerializeField] private Transform _target;
    public override void Init(Transform transform)
    {
        _transform=transform;
    }

    public override void Rotate()
    {
        if(_target==null) return;

        Vector3 TargetPosition = _target.position;
        TargetPosition.z=-(_transform.position.x-Services.MainCamera.transform.position.x);
        _transform.rotation=Quaternion.LookRotation(Vector3.forward,TargetPosition-_transform.position);

    }
    public override void SetTarget(Transform target)
    {
        _target=target;
        Debug.Log($"setted target {_target?.name}");
    }
}
