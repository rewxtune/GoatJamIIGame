using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

public int Water;
public int Mana;
    public int food;
    public int weapon;
    public int speed;

    public Text water_text;
    public Text mana_text;
    public Text food_text;
    public Text weapon_text;
    public Text speed_text;


    void Start()
{
        Water = PlayerPrefs.GetInt("water");
        Mana = PlayerPrefs.GetInt("mana");
        food = PlayerPrefs.GetInt("health");
        weapon = PlayerPrefs.GetInt("weapon");
        speed = PlayerPrefs.GetInt("speed");
        Water = 400;
        water_text.text = Water.ToString();
        mana_text.text = Mana.ToString();
        food_text.text = food.ToString();
        weapon_text.text = weapon.ToString();
        speed_text.text = speed.ToString();

    }
    
    public void BuyMana()
    {
        if (Water >= 150)
        {
            Water -= 150;
            water_text.text = Water.ToString();

            Mana += 1;
            mana_text.text = Mana.ToString();
            Debug.Log("Mana bought! Current Mana: " + Mana);

            PlayerPrefs.SetInt("water", Water);
            PlayerPrefs.SetInt("mana", Mana);
        }
        else
        {
            Debug.Log("Not enough water to buy mana.");
        }
    }
    public void Buyfood()
    {
        if (Water >= 150)
        {
            Water -= 150;
            water_text.text = Water.ToString();

            Mana += 1;
            food_text.text = food.ToString();
            Debug.Log("Mana bought! Current Mana: " + Mana);

            PlayerPrefs.SetInt("water", Water);
            PlayerPrefs.SetInt("mana", Mana);
        }
        else
        {
            Debug.Log("Not enough water to buy mana.");
        }
    }
    public void Buyweapon()
    {
        if (Water >= 150)
        {
            Water -= 150;
            water_text.text = Water.ToString();

            Mana += 1;
            food_text.text = food.ToString();
            Debug.Log("Mana bought! Current Mana: " + Mana);

            PlayerPrefs.SetInt("water", Water);
            PlayerPrefs.SetInt("mana", Mana);
        }
        else
        {
            Debug.Log("Not enough water to buy mana.");
        }
    }
    public void Buyspeed()
    {
        if (Water >= 150)
        {
            Water -= 150;
            water_text.text = Water.ToString();

            Mana += 1;
            speed_text.text = speed.ToString();
            Debug.Log("Mana bought! Current Mana: " + Mana);

            PlayerPrefs.SetInt("water", Water);
            PlayerPrefs.SetInt("mana", Mana);
        }
        else
        {
            Debug.Log("Not enough water to buy mana.");
        }
    }


}
