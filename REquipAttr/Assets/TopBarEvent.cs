using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TopBarEvent : MonoBehaviour
{
    public Transform toolbar;
    Vector3 m_OPos;

    IEnumerator Temp;

    private void Start()
    {
        m_OPos = toolbar.localPosition;
        
    }


    public void MouseEnter(BaseEventData e)
    {
        Temp = Move();
        if (toolbar.localPosition == m_OPos)
        {
            StartCoroutine(Temp);
           
        }

        Debug.Log("进入");
    }
    public void MouseExit(BaseEventData e)
    {
        StopCoroutine(Temp);
        toolbar.localPosition = m_OPos;

        Debug.Log("离开");
    }

    IEnumerator Move()
    {
        // 1= 1000ms
        var mSeconds = 0.1f;
        var number = 60.0f * mSeconds;
        var mFrames = 1.0f / 60.0f;
        for (int i = 0; i < number; i++)
        {
            toolbar.localPosition += new Vector3(0, -30.0f/ number , 0);
            
            yield return new WaitForSeconds(mFrames);
        }
    }
}
