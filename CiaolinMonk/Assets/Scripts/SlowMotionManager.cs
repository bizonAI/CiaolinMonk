using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLenght = 2f;


    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void DoSlowMotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

    public void UndoSlowMotion()
    {
        Time.timeScale = 1f;
    }

   
}
