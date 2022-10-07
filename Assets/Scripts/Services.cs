using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Services : MonoBehaviour
{
    public static Services instance;

    public static Camera MainCamera;
    public Unit Player;
    public static List<Unit> Units;

    private void Awake()
    {
        if(instance==null)
        {
            instance=this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        InitServices();
    }

    private void InitServices()
    {
        MainCamera=Camera.main;
        Units=new List<Unit>();
    }
}
