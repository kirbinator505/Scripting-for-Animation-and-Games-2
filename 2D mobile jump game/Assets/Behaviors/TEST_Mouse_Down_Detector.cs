using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TEST_Mouse_Down_Detector : MonoBehaviour
{
    public Vector2 mouseDown, mouseUp;
    public UnityEvent setGamePlaying, launchPlayer;
    public Bool_SO gamePlaying, gameActive, jumpAvailable;
    public Vector2_SO launchDirection;

    void Start()
    {
        jumpAvailable.value = true;
    }

    private void OnMouseDown()
    {
        mouseDown = Input.mousePosition;
    }

    public void OnMouseUp()
    {
        mouseUp = Input.mousePosition;

        launchDirection.value.x = (mouseDown.x - mouseUp.x);
        launchDirection.value.y = (mouseDown.y - mouseUp.y);

        if (launchDirection.value.y > 100)
        {
            launchDirection.value.y = 100;
        }

        if (launchDirection.value.x > 50)
        {
            launchDirection.value.x = 50;
        }

        if (launchDirection.value.x < -50)
        {
            launchDirection.value.x = -50;
        }

        if (gameActive.value)
        {
            if (jumpAvailable.value)
            {
                launchPlayer.Invoke();
                if (gamePlaying.value == false)
                {
                    setGamePlaying.Invoke();
                }
            }
        }
    }
}
