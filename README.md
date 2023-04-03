# Draconian Scaffold Unity Project #
This is a project designed to be a structure that can be imported for handling commonly needed things that are reimplemented on most Unity based projects. 

## Features
- A main/perpetual-scene with a main controller for managing global game states, and additively loading other scenes for various screens & levels when required. The aim for the main controller's not to have a "God class", but rather to have a manager that delegates these tasks to sub-controllers it has references to. 

- Scene loading: The main controller will load an initial scene based on a Scriptable Object that holds a scene build index. We've built a menu item that both tells the editor to use the first scene in the Hierarchy view as the main/persistent-scene when entering "play mode", while setting the second scene in the editors Hierarchy view's build index to the initial scene loaded. Running this when starting an editor session, or changing the 2nd scene allows you to edit a second scene, & also load it in play-mode as if your project was a stand-alone build outside of the editor(minus performance & other issue experience running inside the editor). 

- Level-managers. Each level can have it's own mostly unique level-manager, based on our base-level-manager which will register it's self with the main controller when it's scene's loaded & it's behavior starts. Basing the main manager/controller for a level on our base-manager ties it into generic things required in each level. Having level managers also allows the games main controller to delegate generic tasks rather than knowing anything about how they're implemented. 

- A skinnable GUI with it's own main-manager. In Scaffold we will include prefabs for the standard Unity-GUI(uGUI) views & widgets. These will be structured as nested prefabs & prefab variants, allowing changes to styles/skins to be made in a single prefab while manifesting across the game's GUIs. 

## TO DOs ##
- [x] Add create-menu items for spawning DGUI prefabs. 
    - [x] Text
    - [x] Button
    - [x] Toggle
    - [x] Slider
    - [x] Scroll Bar
    - [x] Scroll View
    - [x] Input Field
    - [x] Panel
    - [x] Drop Down

- [ ] Add something to set what scene to load running a production build /v testing. 
- [ ] See if there's a way to figure out if the editor initial-load scene's set & add warning. 
- [ ] See if there's a way to auto run the script to set the initial editor scene load on startup. 
- [ ] See if there's a way to add scenes to the build configuration programatically. 

- [x] Add all standard uGUI prefabs. 
    - [x] Text
    - [x] Button
    - [x] Toggle
    - [x] Slider
    - [x] Scroll Bar
    - [x] Scroll View
        - [x] Fix behavior. 
    - [x] Input Field
        - [x] Fix behavior. 
    - [x] Panel
    - [x] Drop Down

## Dog Food Game TO DOs ##
- [x] Load Level 1 scene when "Start" button's pressed. 
