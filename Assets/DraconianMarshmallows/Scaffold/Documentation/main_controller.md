# Scaffold: MainController #

This is your main controller for the entire game. It should delegate tasks to various sub-controllers to manage global aspects of your game. 

For instance: you may have a physics manager to tell the engine what layer-masks should be able to interact. The main controller shouldn't directly know how that's implemented, it should delegate the decision to a child object that wraps what it's doing with the engine. In this way we break out what we want setup in our game from how it's done with Unity. 
