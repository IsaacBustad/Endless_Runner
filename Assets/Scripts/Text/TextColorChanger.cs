using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextColorChanger : MonoBehaviour
{
    [SerializeField] private TMP_Text tmp;


    private void OnEnable()
    {
        tmp.text = "<color=\"blue\"> I am blue \nDa Ba De Da Ba Di \nDa Ba De \nDa Ba Di \nDa Ba De Da Ba Di </color>";
    }
}
