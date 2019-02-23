using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionManager : MonoBehaviour
{
    float standartTime = 1f;
    public float slowdownFactor = 0.05f;
    public float slowdownLenght = 2f;


    /*void Update()
    {
        Time.timeScale += (1f / slowdownLenght) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
    */

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
