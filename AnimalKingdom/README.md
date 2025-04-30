# Animal Kingdom Class Diagram

```mermaid
classDiagram
    class Animal {
        +string Sound()
    }

    class Dog {
        +Sound(): string
    }

    class Cat {
        +Sound(): string
    }

    class Bat {
        +Sound(): string
    }

    class Bee {
        +Sound(): string
    }

    class IMammal {
        +NumberOfNipples: int
    }

    class IICanFly {
        +NumberOfWings: int
    }

    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Bat
    Animal <|-- Bee

    IMammal <|.. Dog
    IMammal <|.. Cat
    IMammal <|.. Bat

    IICanFly <|.. Bat
    IICanFly <|.. Bee