using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    // Vars
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float curHealth = 0;

    // representation on canvas
    [SerializeField] private Image healthBar = null;

    private Vector3 initHealthBarDim = Vector3.zero;


    // Methods
    private void OnEnable()
    {
        curHealth = maxHealth;

        initHealthBarDim = healthBar.rectTransform.localScale;
    }

    public void TakeDammage(float aDam)
    {
        curHealth -= aDam;

        RefreshHealtDisp();

        OutOfHealth();
    }


    public void RefreshHealtDisp()
    {
        if (healthBar != null)
        {
            Vector3 nHealthScale = initHealthBarDim;

            nHealthScale.x = Mathf.Clamp(nHealthScale.x * curHealth / maxHealth, 0, initHealthBarDim.x) ;

            healthBar.rectTransform.localScale = nHealthScale;
        }
    }

    private void OutOfHealth()
    {
        if (curHealth <= 0) 
        { 
            //Destroy(gameObject);
        }
    }

    
}
