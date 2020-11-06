using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public MainScript game;
    public void Click()
    {
        game.data.life += game.data.lifeClickValue;
    }

    public void CollectSouls()
    {
        if (game.data.souls >= 10)
        {
            game.data.darkSouls += game.data.souls / 10;
            game.data.lightSouls += game.data.souls / 10;
        }
        game.SoulSiege();
        game.data.souls = 0;
        game.data.life = 0;
        game.data.lifeClickValue = 1;
    }
    public void BuyClickUpgrade1()
    {
        if (game.data.life >= game.data.clickUpgrade1Cost)
        {
            game.data.clickUpgrade1Level++;
            game.data.life -= game.data.clickUpgrade1Cost;
            game.data.clickUpgrade1Cost *= 1.07;
            game.data.lifeClickValue += (1 * game.data.clickUpgrade1Power * game.data.soulsBoost);
        }
    }

    public void BuyClickUpgrade2()
    {
        if (game.data.life >= game.data.clickUpgrade2Cost)
        {
            game.data.clickUpgrade2Level++;
            game.data.life -= game.data.clickUpgrade2Cost;
            game.data.clickUpgrade2Cost *= 1.09;
            game.data.lifeClickValue += (1 * game.data.clickUpgrade2Power * game.data.soulsBoost);
        }
    }

    public void BuyClickUpgrade3()
    {
        if (game.data.life >= game.data.clickUpgrade3Cost)
        {
            game.data.clickUpgrade3Level++;
            game.data.life -= game.data.clickUpgrade3Cost;
            game.data.clickUpgrade3Cost *= 1.11;
            game.data.lifeClickValue += (1 * game.data.clickUpgrade3Power * game.data.soulsBoost);
        }
    }

    public void BuyClickUpgrade4()
    {
        if (game.data.life >= game.data.clickUpgrade4Cost)
        {
            game.data.clickUpgrade4Level++;
            game.data.life -= game.data.clickUpgrade4Cost;
            game.data.clickUpgrade4Cost *= 1.13;
            game.data.lifeClickValue += (1 * game.data.clickUpgrade4Power * game.data.soulsBoost);
        }
    }
    public void BuyClickUpgrade5()
    {
        if (game.data.life >= game.data.clickUpgrade5Cost)
        {
            game.data.clickUpgrade5Level++;
            game.data.life -= game.data.clickUpgrade5Cost;
            game.data.clickUpgrade5Cost *= 1.15;
            game.data.lifeClickValue += (1 * game.data.clickUpgrade5Power * game.data.soulsBoost);
        }
    }
    public void BuyClickUpgrade6()
    {
        if (game.data.life >= game.data.clickUpgrade6Cost)
        {
            game.data.clickUpgrade4Level++;
            game.data.life -= game.data.clickUpgrade6Cost;
            game.data.clickUpgrade6Cost *= 1.17;
            game.data.lifeClickValue += (1 * game.data.clickUpgrade6Power * game.data.soulsBoost);
        }
    }

    public void BuyProductionUpgrade1()
    {
        if (game.data.life >= game.data.productionUpgrade1Cost)
        {
            game.data.productionUpgrade1Level++;
            game.data.life -= game.data.productionUpgrade1Cost;
            game.data.productionUpgrade1Cost *= 1.07;
        }
    }

    public void BuyProductionUpgrade2()
    {
        if (game.data.life >= game.data.productionUpgrade2Cost)
        {
            game.data.productionUpgrade2Level++;
            game.data.life -= game.data.productionUpgrade2Cost;
            game.data.productionUpgrade2Cost *= 1.09;
        }
    }

    public void BuyProductionUpgrade3()
    {
        if (game.data.life >= game.data.productionUpgrade3Cost)
        {
            game.data.productionUpgrade3Level++;
            game.data.life -= game.data.productionUpgrade3Cost;
            game.data.productionUpgrade3Cost *= 1.11;
        }
    }

    public void BuyProductionUpgrade4()
    {
        if (game.data.life >= game.data.productionUpgrade4Cost)
        {
            game.data.productionUpgrade4Level++;
            game.data.life -= game.data.productionUpgrade4Cost;
            game.data.productionUpgrade4Cost *= 1.13;
        }
    }

    public void BuyProductionUpgrade5()
    {
        if (game.data.life >= game.data.productionUpgrade5Cost)
        {
           game.data.productionUpgrade5Level++;
           game.data.life -= game.data.productionUpgrade5Cost;
           game.data.productionUpgrade5Cost *= 1.15;
        }
    }

    public void BuyProductionUpgrade6()
    {
        if (game.data.life >= game.data.productionUpgrade6Cost)
        {
            game.data.productionUpgrade6Level++;
            game.data.life -= game.data.productionUpgrade6Cost;
            game.data.productionUpgrade6Cost *= 1.17;
        }
    }


    public void BuyClickMulti1()
    {
        game.data.clickMultiplier1 = 2.00;
        if (game.data.darkSouls >= game.data.clickMultiplier1Cost)
        {
            game.data.clickMultiplier1Level++;
            game.data.darkSouls -= game.data.clickMultiplier1Cost;
            game.data.clickMultiplier1Cost *= 1.21;
            game.data.clickUpgrade1Power *= 2;
            game.data.clickUpgrade2Power *= 2;
            game.data.clickUpgrade3Power *= 2;
            game.data.clickUpgrade4Power *= 2;
            game.data.clickUpgrade5Power *= 2;
            game.data.clickUpgrade6Power *= 2;
        }
    }
    public void BuyClickMulti2()
    {
        game.data.clickMultiplier2 = 3.50;
        if (game.data.darkSouls >= game.data.clickMultiplier2Cost)
        {
            game.data.clickMultiplier2Level++;
            game.data.lightSouls -= game.data.clickMultiplier2Cost;
            game.data.clickMultiplier2Cost *= 1.25;
            game.data.clickUpgrade1Power *= 3.5;
            game.data.clickUpgrade2Power *= 3.5;
            game.data.clickUpgrade3Power *= 3.5;
            game.data.clickUpgrade4Power *= 3.5;
            game.data.clickUpgrade5Power *= 3.5;
            game.data.clickUpgrade6Power *= 3.5;
        }
    }
    public void BuyProductionMulti1()
    {
        game.data.productionMultiplier1 = 2.00;
        if (game.data.lightSouls >= game.data.productionMultiplier1Cost)
        {
            game.data.productionMultiplier1Level++;
            game.data.lightSouls -= game.data.productionMultiplier1Cost;
            game.data.productionMultiplier1Cost *= 1.21;
            game.data.productionUpgrade1Power *= 2;
            game.data.productionUpgrade2Power *= 2;
            game.data.productionUpgrade3Power *= 2;
            game.data.productionUpgrade4Power *= 2;
            game.data.productionUpgrade5Power *= 2;
            game.data.productionUpgrade6Power *= 2;
        }
    }
    public void BuyProductionMulti2()
    {
        game.data.productionMultiplier2 = 3.50;
        if (game.data.lightSouls >= game.data.productionMultiplier2Cost)
        {
            game.data.productionMultiplier2Level++;
            game.data.lightSouls -= game.data.productionMultiplier2Cost;
            game.data.productionMultiplier2Cost *= 1.25;
            game.data.productionUpgrade1Power *= 3.5;
            game.data.productionUpgrade2Power *= 3.5;
            game.data.productionUpgrade3Power *= 3.5;
            game.data.productionUpgrade4Power *= 3.5;
            game.data.productionUpgrade5Power *= 3.5;
            game.data.productionUpgrade6Power *= 3.5;
        }
    }
    public void BuySoulsMulti1()
    {
        game.data.soulsMultiplier1 = 1.50;
        if (game.data.darkSouls >= game.data.soulsMultiplier1Cost)
        {
            game.data.soulsMultiplier1Level++;
            game.data.darkSouls -= game.data.soulsMultiplier1Cost;
            game.data.soulsMultiplier1Cost *= 1.31;
            game.data.soulsBoost = (game.data.souls * 0.03) + 1;
        }
    }
    public void BuySoulsMulti2()
    {
        game.data.soulsMultiplier2 = 3.50;
        if (game.data.lightSouls >= game.data.soulsMultiplier2Cost)
        {
            game.data.soulsMultiplier2Level++;
            game.data.lightSouls -= game.data.soulsMultiplier2Cost;
            game.data.soulsMultiplier2Cost *= 1.33;
            game.data.soulsBoost = (game.data.souls * 0.03) + 1;
        }
    }
}
