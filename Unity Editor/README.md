# Unity Editor Interface

![Unity Editor](https://connect-prd-cdn.unity.com/20190501/learn/images/dd1b7c79-6c70-4328-9704-c9591aba5a3a_1.3_UnityEditor.png)

## Scene view and Game view
In the center of the default Unity Editor layout is the **Scene view**. This is your interactive window into the world you are creating. You’ll use the Scene view to manipulate objects and view them from various angles.<br><br>
In the default layout, the **Game view** also appears in this area; you’ll use the Game view to playtest your game.

## Hierarchy window
The **Hierarchy** is where you can organize all the things in your game world (and the world itself). These things are called **GameObjects**.<br><br>
If you add a GameObject to your project in Scene view, it will be listed in the Hierarchy. If you delete a GameObject from the Scene, it will no longer be listed.

## Project window
The **Project window** is where you can find all the files (assets) available for use in your project, whether you use them or not.<br><br>
The Project window works like a file explorer, organized in folders. You can drag assets directly from the Project window into the Scene view to add them to the Scene.<br><br>
Note the difference between the Project and Hierarchy windows: the Hierarchy contains all the GameObjects in the current Scene, and the Project window contains all the assets available to your entire project.

## Inspector window
The **Inspector** is where you’ll find and configure detailed information about GameObjects.<br><br>
When you select a GameObject in Scene view or in the Hierarchy, you’ll see its **components** in the Inspector. Components describe the properties and behaviors of GameObjects.

## Toolbar
The Toolbar is always at the top of the Unity Editor interface. Use the toolbar buttons to select and adjust GameObjects, change your point of view in the Scene, and start and stop Play Mode. 

## Editor layouts
Use the **Layout** menu in the Toolbar to change the arrangement of the windows in the Editor. There are several layouts provided, and you can save your own layouts.<br><br>
The best layout for the Editor depends on what you are doing and your own personal preferences. For example:<br>
* If you’re spending a lot of time configuring components, you might want to dock the Inspector next to the Hierarchy.<br>
* If you’re doing a lot of environment design, you might want to make the Scene view as large as possible.<br>
* If you’re editing the user interface, you’ll want to make sure the Game view is visible.<br>

We recommend you use the default layout while completing this course.

## More about scenes
Projects in Unity Editor are organized into **Scenes**. Scenes are containers for everything in the experience you are creating.<br><br>
One way to think about Scenes is as discrete experiences. For example, each level in a game could be a separate Scene, and the game’s main menu could be another.<br><br>
A Unity project can have one Scene or more than a hundred, depending on its scope and complexity. There aren’t strict rules about exactly how you should organize a Unity project into Scenes, except that a project in Unity must have at least one Scene.

## Navigating the Scene
When working in Scenes, you’ll want to navigate the Scene view easily. Navigating the Scene is like operating a drone camera — it lets you examine your GameObjects from any angle or distance.<br><br>
In the Microgame, you navigated your Scene by changing position, angle, and zoom of the Scene view.  With practice, you can learn to navigate with ease. There are also more general settings you can use to configure the Scene view.<br><br> 
Let’s quickly review the basics:
* **Pan:** Select the Hand tool in the Toolbar, and click and drag in the Scene view to move your view.

* **Zoom:** Holding Alt (Windows) or Option (macOS), right-click and drag in the Scene view to zoom.

* **Orbit:** Holding Alt (Windows) or Option (macOS),  left-click and drag to orbit around the current pivot point. Note: this option is not available in 2D mode.

* **Focus (Frame Select):** When a GameObject is selected, select **F** with your cursor in the Scene view to focus your view on that GameObject. Note: if your cursor is not in the Scene view, Frame Select will not work.
<br><br>

You can also use Flythrough mode to navigate in the Scene view by flying around in first person, which is common in many games. To do this:<br><br>
* Click and hold the right mouse button.
* Use **WASD** to move the view left/right/forward/backward.
* Use **Q** and **E** to move the view up and down.
* Select and hold **Shift** to move faster.
<br><br>
Note: Flythrough mode is not available in 2D mode. Instead, holding the right mouse button down while moving the cursor pans around the Scene view.
