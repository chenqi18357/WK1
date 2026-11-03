### Game 
Link https://wsmyyzcry.itch.io/wk1
### Devlog WK1
Moved the cat to the green platform.
It won't move when I click WASD, because it is not linked with the cat Gameobject transform, and not controlled by player.cs.

### Devlog MG1

Scenes is like place in the real world, such as a city or a school. GameObjects are the things exists in the place, such as people, buildings, and water. They are different, but they are all represented as GameObjects. Components are like the traits and abilities added on different objects. For example, human has a collider, a detector, and an ability(script) to move, while the floors only have a collider (because they can't move), and the water has a its own collide behavior. By using different components, the GameObjects can behave differently in the scene.

### Devlog WK2

1 Because the color in unity requires there elementss from 0 to 1, and the float variable best suits to represent a value between 0 and 1.

2 Because _bounce represents the a count of times the ball bounce, it is not a demical, and can't be a bool or string.

3 I forget to write a f and the end of a demical, now I realize if I want to create a value in float but not double, I have to add a f at the end.

### Devlog WK3
```csharp
// 1
String GetResponse(int friendshipLevel,boolean knowSecret)
//2
void SetLightDimness(float sanityLevel)
//3
boolean DidPlayerHitBeat(float hitTime,float beatTime,float timeInterval)
//or
boolean DidPlayerHitBeat(Vector3 hitPos,Vecctor3 beatPos,float distance)
```

Class is like a blueprint for everything(GameObjects, Conponents, parameters in a component, and value), and a Components is like a part of a human(GameObject), the human's blueprint is also a class, the parameters' blueprint in that component is also a class.

The ball gets extreamly bright because every time it bounce, the velocity will be multipulate by the _speedMultiplier, so the formular of velocity is original*_speedMultiplier^bounceTimes.

### Devlog WK4 Group#7

1 

collider and rigidbody(kenetic) for cat, because it is only controlled by player, shouldn't affect by collusion

collider and rigidbody for soccer, because it is affected by the collusion from player

collider(isTriger) and rigidbody(kinetic) for goal, because it is used to detect the soccer and let the soccer comes across it.

2 I mistakenly used a collide detector instead of Triger detector in the code for soccer, so it didn't work initially, then I check the script form pizza in WK2 to fix it.
