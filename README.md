# Strategy Pattern

### This is an example of using the strategy pattern based on the exercises from "Head First Design Pattern".

The Fight function is defined in the Character class and each character type implements its own fighting behavior. The Character class has a behavior that the user can utilize with the selected character's strategy.

The following figure displays the class diagram of the implemented solution:

```mermaid
---
title: Action Adventure Game
---
classDiagram
    Character <|-- Queen : Extends
    Character <|-- King : Extends
    Character <|-- Troll : Extends
    Character <|-- Knight : Extends
    Character --> IWeaponBehavior : HAS-A
    KnifeBehavior ..|> IWeaponBehavior : Implements
    BowAndArrowBehavior ..|> IWeaponBehavior : Implements
    AxeBehavior ..|> IWeaponBehavior : Implements
    SwordBehavior ..|> IWeaponBehavior : Implements
    class Character{
        <<Abstract>>
       +IWeaponBehavior weapon
       +setBehavior(IWeaponBehavior w)
       +flight()
    }
    class Queen {
        +flight()
    }
    class King {
        +flight()
    }
    class Troll {
        +flight()
    }
    class Knight {
        +flight()
    }
    class KnifeBehavior {
        +useWeapon()
    }
    class BowAndArrowBehavior{
        +useWeapon()
    }
    class AxeBehavior {
        +useWeapon()
    }
    class SwordBehavior {
        +useWeapon()
    }
    class IWeaponBehavior{
        <<interface>>
        +useWeapon()
    }
```

***

The next definition was taken from the book: 

"The **Strategy Pattern** defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it."

