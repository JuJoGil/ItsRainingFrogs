using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtons : MonoBehaviour
{
    public GameObject shop;
    public GameObject[] hadicaps;


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
    }

    public void NormalSkin()
    {
        PlayerPrefs.SetInt("Skin", 0);
    }
    public void RedSkin()
    {
        PlayerPrefs.SetInt("Skin", 1);
    }
    public void PinkSkin()
    {
        PlayerPrefs.SetInt("Skin", 2);
    }
    public void BrownSkin()
    {
        PlayerPrefs.SetInt("Skin", 3);
    }
    public void ChristmasSkin()
    {
        PlayerPrefs.SetInt("Skin", 4);
    }
    public void BallSkin()
    {
        PlayerPrefs.SetInt("Skin", 5);
    }
    public void InvertSkin()
    {
        PlayerPrefs.SetInt("Skin", 6);
    }
    public void BotSkin()
    {
        PlayerPrefs.SetInt("Skin", 7);
    }
    public void OpenShop()
    {
        shop.SetActive(true);
    }
    public void CloseShop()
    {
        shop.SetActive(false);
    }
    public void MoreSpeed()
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
    public void MoreRocks()
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
    public void MoreBirds()
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
    public void MoreCloud()
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
    public void MoreWind()
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
