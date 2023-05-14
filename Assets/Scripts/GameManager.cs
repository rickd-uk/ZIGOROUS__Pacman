using UnityEngine;

public class GameManager : MonoBehaviour
{
  public Ghost[] ghosts;
  public Pacman pacman;
  public Transform pellets;

  public int score { get; private set; }
  public int lives { get; private set; }
  private void Start()
  {
    NewGame();
  }

  private void NewGame()
  {
    SetScore(0);
    SetLives(3);
  }


  private void SetScore(int score)
  {
    this.score = score;
  }
  private void SetLives(int lives)
  {
    this.lives = lives;
  }
}
