using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public QnAManager manager;
    public void click_O()
    {
        Debug.Log("O");
        manager.input = "O";
        if (manager.check())
        {
            manager.score++;
        }
        manager.index++;
    }
    public void click_X()
    {
        Debug.Log("X");
        manager.input = "X";
        if (manager.check())
        {
            manager.score++;
        }
        manager.index++;
    }
}
