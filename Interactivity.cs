using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolKit.Unity.InputModule;
using System.Timers;

public class Interactivity : MonoBehaviour, IFocasable, IInputClickHandeler
{
    public Timer timeout = new Timer();
    public gameObject target;
    public List<gameObject> pointShoot;

    public Start()
    {
        pointShoot = new List<gameObject>(10);
    }
    public void OnFocusEnter() 
    {
        timeout.Interval = 1000;
        timeout.Start();
        while (true) 
        { 
        }
        if (timeout.ElapsedMilliseconds > 0) 
        {
            timeout.Stop();
            gameObject.GetComponent<objDestroy>().destroy();
            timeout.Interval = 1000;
        }
    }
    public void OnFocusExit() 
    {
        timeout.Stop();
        timeout.Interval = 1000;
    }
}

public class objDestroy : MonoBehavior
{

}
