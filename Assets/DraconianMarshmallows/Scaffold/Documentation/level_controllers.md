# Scaffold: BaseLevelManager #

This is a base/super-class meant to be extended & handle anything specific to a level. 

By extending `BaseLevelManager`, your level-manager for any level will register it's self with a main-controller for your game when your level-scene starts. A main-controller(which extends Scaffolds `BaseMainController`) will in-turn call-back to the level-controllers `OnUpdate` method when Unity runs your main `Update` method on your main controller. This is sort-of a work around for a performance hit that's possible if you project has too many `Update` methods in MonoBehaviour scripts. Your level-manager can then in-turn call back to `OnUpdate` methods on level-specific code it knows about. 

It's intended that a level-manager delegates global functionality upwards to the projects main-controller, as well as understanding & managing other objects in a level-scene. 
