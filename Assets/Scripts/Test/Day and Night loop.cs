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
        
    }

    void StartNight()
    {
        isDaytime = false;
      
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
       
    }

    public void LoseGame()
    {
       
    }
}

