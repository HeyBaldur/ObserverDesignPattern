# Observer Design Pattern [![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT) [![Open Source? Yes!](https://badgen.net/badge/Open%20Source%20%3F/Yes%21/blue?icon=github)](https://en.wikipedia.org/wiki/Open_source)

Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their state.

The Observer pattern provides a way to subscribe and unsubscribe to and from these events for any object that implements a subscriber interface.

*Usage examples*: The Observer pattern is pretty common in C# code, especially in the GUI components. It provides a way to react to events happening in other objects without coupling to their classes.

*Identification*: The pattern can be recognized by subscription methods, that store objects in a list and by calls to the update method issued to objects in that list.
