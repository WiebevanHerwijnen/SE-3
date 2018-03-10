using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    public Image healthbar;

    public Sprite one_hp;
    public Sprite two_hp;
    public Sprite three_hp;
    public Sprite four_hp;

  public int currenthealth;
    int maxhealth;
    int minhealth;

    private void Start()
    {
        currenthealth = 3;
        maxhealth = 4;
        minhealth = 1;

    }

    private void Update()
    {
#region healthbarstuff
        if (Input.GetKeyDown(KeyCode.Q))
        {
            HealthDown();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            HealthUp();
        }
        if (currenthealth == 1)
        {
            healthbar.sprite = one_hp;
        }
        if (currenthealth == 2)
        {
            healthbar.sprite = two_hp;
        }
        if (currenthealth == 3)
        {
            healthbar.sprite = three_hp;
        }
        if (currenthealth == 4)
        {
            healthbar.sprite = four_hp;
        }
        if(currenthealth == maxhealth)
        {
            currenthealth = 4;
        }
        if (currenthealth == minhealth)
        {
            currenthealth = 1;
        }
        #endregion

    }

    public void HealthDown()
    {
        currenthealth--;
    }
    public void HealthUp()
    {
        currenthealth++;
    }



}
