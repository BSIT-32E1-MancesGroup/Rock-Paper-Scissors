# Rock-Paper-Scissors



User Stories and Separate Concerns for Rock-Paper-Scissors in MVC
As a user, I want to...

1. Choose my hand:

Select one of the three options: Rock, Paper, or Scissors from a user interface (e.g., buttons or radio buttons).
2. Play against the computer:

Click a "Play" or "Submit" button to initiate the game and compare my choice with the computer's.
3. See the results:

View the outcome of the game displayed clearly, indicating if I win, lose, or tie.
Optionally, see the computer's hand choice revealed after the result.
4. Play again (optional):

Optionally, have the option to play another round by clicking a "Play Again" button, restarting the game.
Separate Concerns:

1. Model (Optional):

You might consider a Hand class to represent the rock, paper, and scissors options, but it's not strictly necessary for a simple game.
2. Controller:

GameController: Handles user input (selecting hand), determines the winner based on game logic, and displays the results.
3. View:

Game view: Provides a user interface with buttons or radio buttons for selecting hand options.
Displays the game outcome (win, lose, tie) and optionally reveals the computer's hand.
Includes a "Play Again" button (optional) to initiate another round.
4. Services (Optional):

While not necessary for this basic implementation, you could consider using a service to encapsulate the game logic, especially if you plan to expand the functionality in the future (e.g., different play modes, statistics).
Note: This is a simplified version, focusing on the core gameplay. You can add complexity to the user interface, game logic, and functionality based on your specific interests and learning objectives.
