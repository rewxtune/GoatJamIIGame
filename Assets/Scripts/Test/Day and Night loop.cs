using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentDay = 1;
    public int maxDays = 14;
    public bool isDaytime = true;

    void Start()
    {
        StartDay();
    }

    void StartDay()
    {
        isDaytime = true;
        // Kazý zamaný, enerji kazanýlýr
    }

    void StartNight()
    {
        isDaytime = false;
        // Fýrtýna baþlar, gemiye dönülmeli
    }

    public void EndDay()
    {
        currentDay++;
        if (currentDay > maxDays)
        {
            WinGame();
        }
        else
        {
            StartDay();
        }
    }

    void WinGame()
    {
        // Oyunu kazanma sahnesi
    }

    public void LoseGame()
    {
        // Oyunu kaybetme sahnesi
    }
}

