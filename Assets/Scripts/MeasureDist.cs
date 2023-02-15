using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeasureDist : MonoBehaviour
{
    public TMP_Text textField;
    float bestDistance = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            float dist = Vector3.Distance(Vector3.zero, collision.GetContact(0).point);
            
            if (dist > bestDistance)
            {
                bestDistance = dist;
            }
            
            textField.text = bestDistance.ToString("#.00");
        }
    }
}
