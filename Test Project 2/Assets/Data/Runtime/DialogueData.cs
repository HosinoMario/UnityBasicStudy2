using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class DialogueData
{
  [SerializeField]
  int id_i;
  public int ID_I { get {return id_i; } set { this.id_i = value;} }
  
  [SerializeField]
  string bg;
  public string BG { get {return bg; } set { this.bg = value;} }
  
  [SerializeField]
  int character;
  public int Character { get {return character; } set { this.character = value;} }
  
  [SerializeField]
  int position;
  public int Position { get {return position; } set { this.position = value;} }
  
  [SerializeField]
  string dialogue;
  public string Dialogue { get {return dialogue; } set { this.dialogue = value;} }
  
}