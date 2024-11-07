using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePopupGenerator : MonoBehaviour
{
    public static DamagePopupGenerator current;
    public GameObject prefab;

    private void Awake()
    {
        current = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreatePopup(Vector3 position, string text, Color color)
    {
        var popup = Instantiate(prefab,position,Quaternion.identity);
        var temp = popup.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        temp.text = text;
        temp.color = color;
        Destroy(popup, 1f);
        Destroy(temp, 1f);
    }
}
