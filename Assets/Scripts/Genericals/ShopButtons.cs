using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtons : MonoBehaviour
{
    public GameObject shop, crown;
    public GameObject[] hadicaps;
    public Button[] shopicons;
    public Sprite[] images;
    public AudioSource[] sound;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("Speed") == 0)
        {
            
            hadicaps[0].SetActive(false);
        }
        else
        {
            
            hadicaps[0].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Rock") == 0)
        {

            hadicaps[1].SetActive(false);
        }
        else
        {

            hadicaps[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Bird") == 0)
        {

            hadicaps[2].SetActive(false);
        }
        else
        {

            hadicaps[2].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Cloud") == 0)
        {

            hadicaps[3].SetActive(false);
        }
        else
        {

            hadicaps[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Wind") == 0)
        {

            hadicaps[4].SetActive(false);
        }
        else
        {

            hadicaps[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("Crown") == 1)
        {
            crown.SetActive(true);
        }

        if (PlayerPrefs.GetInt("IconRed") == 1)
        {
            shopicons[1].image.sprite = images[1];
        }
        if (PlayerPrefs.GetInt("IconPink") == 1)
        {
            shopicons[2].image.sprite = images[2];
        }
        if (PlayerPrefs.GetInt("IconBrown") == 1)
        {
            shopicons[3].image.sprite = images[3];
        }
        if (PlayerPrefs.GetInt("IconChr") == 1)
        {
            shopicons[4].image.sprite = images[4];
        }
        if (PlayerPrefs.GetInt("IconBall") == 1)
        {
            shopicons[5].image.sprite = images[5];
        }
        if (PlayerPrefs.GetInt("IconInv") == 1)
        {
            shopicons[6].image.sprite = images[6];
        }
        if (PlayerPrefs.GetInt("IconBot") == 1)
        {
            shopicons[7].image.sprite = images[7];
        }
        if (PlayerPrefs.GetInt("IconSpeed") == 1)
        {
            shopicons[8].image.sprite = images[8];
        }
        if (PlayerPrefs.GetInt("IconRock") == 1)
        {
            shopicons[9].image.sprite = images[9];
        }
        if (PlayerPrefs.GetInt("IconBird") == 1)
        {
            shopicons[10].image.sprite = images[10];
        }
        if (PlayerPrefs.GetInt("IconCloud") == 1)
        {
            shopicons[11].image.sprite = images[11];
        }
        if (PlayerPrefs.GetInt("IconWind") == 1)
        {
            shopicons[12].image.sprite = images[12];
        }
        if (PlayerPrefs.GetInt("IconCrown") == 1)
        {
            shopicons[13].image.sprite = images[13];
        }
        
    }

    public void NormalSkin()
    {
        sound[1].Play();
        PlayerPrefs.SetInt("Skin", 0);
    }
    public void RedSkin()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconRed") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 1)
            {
                PlayerPrefs.SetInt("IconRed", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 1);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("Skin", 1);
        }
        
    }
    public void PinkSkin()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconPink") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 5)
            {
                PlayerPrefs.SetInt("IconPink", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 5);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Skin", 2);

        }
    }
    public void BrownSkin()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconBrown") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 5)
            {
                PlayerPrefs.SetInt("IconBrown", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 5);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("Skin", 3);

        }
    }
    public void ChristmasSkin()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconChr") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 10)
            {
                PlayerPrefs.SetInt("IconChr", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 10);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("Skin", 4);

        }
    }
    public void BallSkin()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconBall") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 10)
            {
                PlayerPrefs.SetInt("IconBall", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 10);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("Skin", 5);

        }
    }
    public void InvertSkin()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconInv") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 10)
            {
                PlayerPrefs.SetInt("IconInv", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 10);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("Skin", 6);

        }
    }
    public void BotSkin()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconBot") == 0)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 10)
            {
                PlayerPrefs.SetInt("IconBot", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 10);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("Skin", 7);

        }
    }
    public void OpenShop()
    {
        sound[0].Play();
        shop.SetActive(true);
    }
    public void CloseShop()
    {
        sound[0].Play();
        shop.SetActive(false);
    }
    public void MoreSpeed()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconSpeed") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 20)
            {
                PlayerPrefs.SetInt("IconSpeed", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 20);
            }
            
        }
        else
        {
           
            if (PlayerPrefs.GetInt("Speed") == 0)
            {
                PlayerPrefs.SetInt("Speed", 1);
            }
            else
            {
                PlayerPrefs.SetInt("Speed", 0);
            }
        }
        
    }
    public void MoreRocks()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconRock") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 10)
            {
                PlayerPrefs.SetInt("IconRock", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 10);
            }
            
        }
        else
        {
            if (PlayerPrefs.GetInt("Rock") == 0)
            {
                PlayerPrefs.SetInt("Rock", 1);

            }
            else
            {
                PlayerPrefs.SetInt("Rock", 0);
            }
        }
        
        
    }
    public void MoreBirds()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconBird") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 10)
            {
                PlayerPrefs.SetInt("IconBird", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 10);
            }
            
        }
        else
        {
            if (PlayerPrefs.GetInt("Bird") == 0)
            {
                PlayerPrefs.SetInt("Bird", 1);

            }
            else
            {
                PlayerPrefs.SetInt("Bird", 0);
            }
        }
        
        
    }
    public void MoreCloud()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconCloud") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 10)
            {
                PlayerPrefs.SetInt("IconCloud", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 10);
            }
            
        }
        else
        {
            if (PlayerPrefs.GetInt("Cloud") == 0)
            {
                PlayerPrefs.SetInt("Cloud", 1);

            }
            else
            {
                PlayerPrefs.SetInt("Cloud", 0);
            }
        }
        
       
    }
    public void MoreWind()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconWind") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 5)
            {
                PlayerPrefs.SetInt("IconWind", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 5);
            }
            
        }
        else
        {
            if (PlayerPrefs.GetInt("Wind") == 0)
            {
                PlayerPrefs.SetInt("Wind", 1);

            }
            else
            {
                PlayerPrefs.SetInt("Wind", 0);
            }
        }
        
        
    }
    public void Crown()
    {
        sound[1].Play();
        if (PlayerPrefs.GetInt("IconCrown") != 1)
        {
            if (PlayerPrefs.GetInt("NumeroBucles") >= 100)
            {
                PlayerPrefs.SetInt("IconCrown", 1);
                PlayerPrefs.SetInt("NumeroBucles", PlayerPrefs.GetInt("NumeroBucles") - 100);
            }

        }
        else
        {
            PlayerPrefs.SetInt("Crown", 1);
        }
    }
}
