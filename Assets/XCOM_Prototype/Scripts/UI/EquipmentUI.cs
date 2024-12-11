using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentUI : MonoBehaviour
{
    private void Awake() {
        transform.Find("OpenEquipmentMenuBtn").GetComponent<Button>().onClick.AddListener(() => {
            EquipmentMenu.Instance.Open();
        });

        transform.Find("EquipmentMenu/CloseEquipmentMenuBtn").GetComponent<Button>().onClick.AddListener(() => {
            EquipmentMenu.Instance.Close();
        });
    }
}
