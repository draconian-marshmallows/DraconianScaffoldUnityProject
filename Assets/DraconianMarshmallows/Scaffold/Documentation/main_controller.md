# Scaffold: MainController #

This is your main controller for the entire Unity base application. It should delegate tasks to sub-controllers to manage various aspects of your multi-media project. Any level-specific management should be handled by a level-manager. This should be a class that extends Scaffold's [BaseLevelManager](/level_controllers.md)  class in order to tie it into the rest of our Scaffold framework. 

## NOTE: MonoBehaviour.Update may be a Performance Hit ##
### I'm actually not sure if that's still an issue...
The base-class for the main-controller in Scaffold has an `OnUpdate` event-delegate other MonoBehaviour objects can benefit from to avoid the performance overhead of having the C++ part of Unity decide to call the `Update` callback on any number of script components derived from `MonoBehaviour`. 

Any Script-Components that use the `OnUpdate` event can inherit from `MonoBehaviorPlus` to be automatically unsubscribe from the event when their OnDestroy method's called by the engine. This was designed to avoid memory leaks. 

## Main Description ##
For instance: you may have a physics manager to tell the engine what layer-masks should be able to interact. The main controller shouldn't directly know how that's implemented, it should delegate the decision to a child object that wraps what it's doing with the engine. In this way we break out what we want setup in our game from how it's done with Unity. 
