using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler
{
    // これまでのフィールド….

    // 指が画面上でドラッグされるたびに呼び出される関数
    public void OnDrag(PointerEventData eventData)
    {
        joystickHandle.position = eventData.position;
    }
}
