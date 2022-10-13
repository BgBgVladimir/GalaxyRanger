using UnityEngine;

[CreateAssetMenu(menuName ="Behaviours/Player/Mowe/PlayerPCMoweBehaviour")]
public class PlayerPCMoweBehaviour: MoweBehaviour
{
    public override void Init(Unit _unit)
    {
        unit=_unit;
        rigidBody2D = _unit.GetComponent<Rigidbody2D>();
    }
    public override void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            addForce(Vector2.up);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            addForce(Vector2.down);
        }
        if(Input.GetKey(KeyCode.A))
        {
            addForce(Vector2.left);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            addForce(Vector2.right);
        }

    }
    private void addForce(Vector2 _moweVector)
    {
        rigidBody2D.AddForce(_moweVector*moweSpeed);
    }
}
