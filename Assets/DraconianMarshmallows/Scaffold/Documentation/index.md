# Scaffold #

## Summery ##
Draconian Scaffold is a framework designed to help structure games build on top of Unity game engine. We hope it's generic enough to work for any game project, & provides helpful implementations for most commonly used features. 

The backbone of the framework is a 
[main-controller](/main_controller.md) 
that delegates tasks to sub-controllers, as well as a sub-controller that extends BaseLevelManager for level-specific tasks. This is designed to have all the commonly used controllers in a main(persistent) Unity scene, and the level sub-controller/manager(as well as any of it's sub-controllers) in scenes additively loaded on top. 
