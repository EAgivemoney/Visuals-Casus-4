using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Clock clock;
    public Image buttonImage;
    public Sprite playSprite;
    public Sprite pauseSprite;

    private bool isPaused = false;

    public void Pause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            clock.enabled = false;
            buttonImage.sprite = playSprite;
        }
        else
        {
            clock.enabled = true;
            buttonImage.sprite = pauseSprite;
        }
    }

    public void Restart()
    {
        clock.ResetTimer();
    }
}
