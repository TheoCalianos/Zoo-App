using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Map_Pannel : MonoBehaviour
{
  public CardView cardPannel;
  [SerializeField] private GameObject button;
  [SerializeField] private string buttonText;
  public void onCardClick()
  {
    button = EventSystem.current.currentSelectedGameObject;
    buttonText = button.GetComponentInChildren<Text>().text.ToString();
    for(int i=0;  i < cardPannel.cards.Length; i++)
    {
      if(buttonText == cardPannel.cards[i].title)
      {
        cardPannel.DisplayCard(i);
        cardPannel.gameObject.SetActive(true);
      }
    }
  }
}
