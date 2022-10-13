using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/Player/Rotation/PlayerPCRotationBehaviour")]
public class PlayerPCRotationBehaviour : RotationBehaviour
{
    public override void Init(Unit _unit)
    {
        unit=_unit;
        _transform=_unit.transform;
    }

    public override void Rotate()
    {
        Vector3 MouseInWorldPosition = Services.MainCamera.ScreenToWorldPoint(Input.mousePosition);
        MouseInWorldPosition.z=-(_transform.position.x-Services.MainCamera.transform.position.x);
        _transform.rotation=Quaternion.LookRotation(Vector3.forward,MouseInWorldPosition-_transform.position);

    }
}
