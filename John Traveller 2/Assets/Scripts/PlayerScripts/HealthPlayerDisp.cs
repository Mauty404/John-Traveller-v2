using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayerDisp : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    PlayerMovement _player;
    float percentageHp;
    
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        percentageHp = _player.hp / _player.hpMax * 100;
        if (percentageHp >= 90 && percentageHp <= 100)
            for (int i = 0; i <= 9; i++)
                hearts[i].sprite = fullHeart;
                

        else if (percentageHp >= 80 && percentageHp < 90)
        {
            for (int i = 0; i <= 8; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 9; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 70 && percentageHp < 80)
        {
            for (int i = 0; i <= 7; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 8; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 60 && percentageHp < 70)
        {
            for (int i = 0; i <= 6; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 7; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 50 && percentageHp < 60)
        {
            for (int i = 0; i <= 5; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 6; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 40 && percentageHp < 50)
        {
            for (int i = 0; i <= 4; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 5; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 30 && percentageHp < 40)
        {
            for (int i = 0; i <= 3; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 4; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 20 && percentageHp < 30)
        {
            for (int i = 0; i <= 2; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 3; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 10 && percentageHp < 20)
        {
            for (int i = 0; i <= 1; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 2; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }

        else if (percentageHp >= 0 && percentageHp < 10)
        {
            for (int i = 0; i <= 0; i++)
                hearts[i].sprite = fullHeart;
            for (int i = 1; i <= 9; i++)
                hearts[i].sprite = emptyHeart;
        }
    }
}
