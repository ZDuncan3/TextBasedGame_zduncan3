using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI textElement;
  [SerializeField] State startState;
  State state;

  void Start()
  {
    state = startState;
    textElement.text = state.GetStateText();
  }

  void Update()
  {
    GameMain();
  }

  private void GameMain()
  {
    State[] statesArray = state.GetOtherStates();
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      state = statesArray[0];
    }
    else if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      state = statesArray[1];
    }

    textElement.text = state.GetStateText();
  }
}
