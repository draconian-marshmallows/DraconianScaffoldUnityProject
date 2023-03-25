# Scaffold: MainController #

This is your main controller for the entire game. It should delegate tasks to sub-controllers to manage various aspects of your game. Any level-specific management should be handled by a level-manager. This should be a class that extends Scaffold's [BaseLevelManager](/level_controllers.md)  class in order to tie it into the rest of our Scaffold framework. 

For instance: you may have a physics manager to tell the engine what layer-masks should be able to interact. The main controller shouldn't directly know how that's implemented, it should delegate the decision to a child object that wraps what it's doing with the engine. In this way we break out what we want setup in our game from how it's done with Unity. 
