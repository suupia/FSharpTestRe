using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using Microsoft.FSharp.Core;
using FSharpTestRe;

public class ShopUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private TextMeshProUGUI numberText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Test.factorial(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
