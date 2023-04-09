# Scaffold #

## Summery ##
Draconian Scaffold is a framework designed to help structure games build on top of Unity game engine. We hope it's generic enough for any game project, & provides helpful implementations for most commonly used features of the engine. 

### NOTE: Try using MonoBehaviorPlus with this framework... 

The core of Scaffold is a service-provider named [main-controller](/main_controller.md) 
that delegates tasks to sub-controllers, as well as a sub-controller that extends BaseLevelManager for level-specific tasks. This is designed to have all the commonly used controllers in a main(PERSISTENT) Unity scene, and the level sub-controller/manager(as well as any of the level-controller sub-controllers) in scenes additively loaded on top. For a game which may have levels with a variety of game-play types you may make multiple sub-classes of BaseLevelManager. 

We included `MonoBehaviorPlus` in Scaffold: 
 - Allowing overriding(most) Unity callbacks when using inheritence. 
 - Work around a known issue with having too many `Update` callback methods defind in `MonoBehaviours` scripts. 
