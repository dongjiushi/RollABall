using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTool : MonoBehaviour
{
    public void PrintPlayerAge()
    {
        Debug.Log(PlayerManager.Instance.playerAge);
    }
}


