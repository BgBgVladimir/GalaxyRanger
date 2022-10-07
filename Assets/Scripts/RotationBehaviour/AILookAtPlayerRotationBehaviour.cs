using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Rotation/AILookAtPlayerRotationBehaviour")]
public class AILookAtPlayerRotationBehaviour: RotationBehaviour
{
    public override void Init(Transform transform)
    {
        _transform=transform;
    }

    public override void Rotate()
    {
        Vector3 PlayerPosition = Services.instance.Player.transform.position;
        PlayerPosition.z=-(_transform.position.x-Camera.main.transform.position.x);
        _transform.rotation=Quaternion.LookRotation(Vector3.forward,PlayerPosition-_transform.position);

    }
}
