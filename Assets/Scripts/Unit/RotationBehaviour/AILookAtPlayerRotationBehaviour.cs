using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Rotation/AILookAtPlayerRotationBehaviour")]
public class AILookAtPlayerRotationBehaviour: RotationBehaviour
{
    public override void Init(Unit _unit)
    {
        unit=_unit;
        _transform=_unit.transform;
    }

    public override void Rotate()
    {
        Vector3 PlayerPosition = new Vector3(0,0,0);
        if(Services.instance.Player)
            PlayerPosition = Services.instance.Player.transform.position;
        PlayerPosition.z=-(_transform.position.x-Camera.main.transform.position.x);
        _transform.rotation=Quaternion.LookRotation(Vector3.forward,PlayerPosition-_transform.position);

    }
}
