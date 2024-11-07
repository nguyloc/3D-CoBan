using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePopUpAnimation : MonoBehaviour
{
    public AnimationCurve opacityCureve;
    public AnimationCurve scaleCureve;
    public AnimationCurve heightCureve;

    private Vector3 origin;
    private TextMeshProUGUI tmp;
    float time = 0;

    private void Awake()
    {
        tmp = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        origin = transform.position;
    }

    private void Update()
    {
        tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, opacityCureve.Evaluate(time));
        transform.localScale = Vector3.one * scaleCureve.Evaluate(time);
        transform.position = origin + new Vector3(0,1 + heightCureve.Evaluate(time),0);
        time += Time.deltaTime;
        
    }
}
