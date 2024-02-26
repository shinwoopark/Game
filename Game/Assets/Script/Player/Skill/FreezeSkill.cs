using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeSkill : BaseSkill
{
    public SoundManager SoundManager;
    public GameObject SoundManager_gb;

    void Start()
    {
        SoundManager_gb = GameObject.Find("Managers");
        SoundManager = SoundManager_gb.GetComponent<SoundManager>();
    }

    public override void Activate()
    {
        base.Activate();
        SoundManager.PlaySFX(3);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject obj in enemies)
        {
            if (obj != null)
            {
                if (obj.layer != 13)
                {
                    Enemy enemy = obj.GetComponent<Enemy>();
                    if (enemy != null)
                    { 
                        enemy.Freezing();
                    }
                }   
            }
        }

    }
}
