# Rock-Paper-Scissors Game in C#

This project is a console-based implementation of the classic **Rock-Paper-Scissors** game written in **C#**. The player competes against the computer, which randomly selects its choice. The game then determines the winner based on the standard rules of Rock-Paper-Scissors.

## Features

- **Random Computer Choice**: The computer randomly selects either Rock, Paper, or Scissors.
- **Player Input**: The player types their choice of Rock, Paper, or Scissors.
- **Win/Loss/Tie Logic**: The game evaluates the player’s choice and compares it to the computer’s choice, determining whether the player wins, loses, or ties.
- **Score Tracking**: The game keeps track of the number of wins, losses, and ties for the player.
- **Replay Option**: After each round, the player is prompted to play again.

## How It Works

1. **Player’s Choice**:
   - The player is prompted to type their choice of either "Rock", "Paper", or "Scissors".
   
2. **Computer’s Choice**:
   - The computer randomly generates its selection using a random number generator to pick Rock, Paper, or Scissors.

3. **Evaluation**:
   - The game compares the player’s choice with the computer’s choice:
     - Rock beats Scissors
     - Scissors beats Paper
     - Paper beats Rock
   - If both the player and computer make the same choice, the result is a tie.

4. **Replay**:
   - After each round, the game asks if the player wants to play again by typing "Yes" or "No".
