using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler
{
    // ����܂ł̃t�B�[���h�c.

    // �w����ʏ�Ńh���b�O����邽�тɌĂяo�����֐�
    public void OnDrag(PointerEventData eventData)
    {
        joystickHandle.position = eventData.position;
    }
}
