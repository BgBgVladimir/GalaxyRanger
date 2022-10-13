using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/Other/Destroy/ParticleEffectDestroyBehaviour")]
public class ParticleEffectDestroyBehaviour :DestroyBehaviour
{
    [SerializeField] private GameObject DestroyEffectPrefab;

    public override void Init(Unit _unit)
    {
        unit=_unit;
    }
    public override void OnUnitDestroy()
    {
        GameObject.Instantiate(DestroyEffectPrefab,unit.transform.position,Quaternion.identity);
    }
}
