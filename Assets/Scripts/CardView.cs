using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardView : MonoBehaviour
{
  public Text title;
  public Text description;
  public Text exhibit;
  public Image animalImg;
  public CardModel[] cards;
  private void OnEnable()
  {

  }
  public void DisplayCard(int index)
  {
    title.text = cards[index].title;
    description.text = cards[index].description;
    exhibit.text = cards[index].exhibit;
    animalImg.sprite = cards[index].animalImg;
  }
  public void closeButton()
  {
    this.gameObject.SetActive(false);
  }
}
