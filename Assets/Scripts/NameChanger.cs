using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameChanger : MonoBehaviour
{
    [SerializeField] private TMP_Text _newNameText;
    [SerializeField] private TMP_Text _boxNameText;

    public void ChangeText()
    {
        _boxNameText.text = _newNameText.text;
    }
}
