using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetTimeScale(0.3f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetTimeScale(0.5f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetTimeScale(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetTimeScale(2);
        }
    }
}
