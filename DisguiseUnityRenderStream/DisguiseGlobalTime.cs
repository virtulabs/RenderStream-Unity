using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;
using System;

public class DisguiseGlobalTime : MonoBehaviour
{
    public UnityAction<float> onTimeUpdate;

    void Update()
    {
        if (DisguiseRenderStream.newFrameData)
        {


            if (onTimeUpdate != null)
            {
               onTimeUpdate((float)DisguiseRenderStream.frameData.localTime);
            }

        }
    }


}
