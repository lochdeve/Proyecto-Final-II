# Simon Dice
- Universidad de La Laguna
- **Asignatura:** Interfaces Inteligentes
- **Proyecto final de Asignatura:** juego en realidad virtual con Unity 3D

## Índice
- [Autores](#autores)
- [Introducción](#introducción)
  - [Descripción del juego](#descripción-del-juego)
  - [Descripción del mapa](#descripción-del-mapa)
- [Estructura de los scripts](#estructura-de-los-scripts)
- [Elementos externos usados](#elementos-externos-usados)
- [Cuestiones importantes para el uso](#cuestiones-importantes-para-el-uso)
- [Hitos de programación logrados](#hitos-de-programación-logrados)
- [Aspectos destacables del juego](#aspectos-destacables-del-juego)
- [Metodología de trabajo](#metodología-de-trabajo)
- [Reparto de tareas](#reparto-de-tareas)
- [Gifs de demostración del juego](#gifs-de-demostración-del-juego)
- [Enlaces de interés](#enlaces-de-interés)
  - [Gameplay del juego](#gameplay-del-juego)
  - [APK](#apk)
  - [Github del Proyecto completo](#github-del-proyecto-completo)
- [Posibles mejoras a futuro](#posibles-mejoras-a-futuro)

## Autores
  - Eduardo Expósito Barrera - alu0101230382@ull.edu.es
  - Carlos García Lezcano - alu0101208268@ull.edu.es
  - Cristo García González - alu0101204512@ull.edu.es
  - Andrés Zeus Hernández Impini - alu0101207957@ull.edu.es

## Introducción
- El juego desarrollado con el nombre de **Simon Dice**, es un juego de **realidad virtual(VR)** desarrollado para dispositivos Android con Unity 3D.
  El mismo ha sido desarrollado a partir de diversas técnicas y conocimientos adquiridos durante la realización de la materia, además de algunas otras características que han sido necesarias aprender durante la realización del proyecto para su correcto funcionamiento.

  ### Descripción del juego
  - Cuando decides iniciar una partida en el juego que hemos desarrollado **Simon Dice**, aparecerás en un escenario oscuro(simulando un bosque nocturno), el cual tiene un camino que te conduce hacia la jugabilidad del **Simon Dice**. Una vez te acerques a la zona, te aparecerá un botón para comenzar a jugar. Si inicias una partida, puedes cancelar la misma pulsando el botón que aparece en la escena o alejándote de la zona de juego. En caso de equivocarte durante la partida, habrás perdido y deberás comenzar una nueva, en caso contrario, podrás llegar hasta un máximo de 10 niveles.
  
  ### Descripción del mapa
  - En el mapa que compone la escena desarrollada, podemos encontrar diferentes objetos, los cuales son:
    - Piedras
    - Hogueras
    - Antorchas
    - Niebla
    - Diversidad de flora(Pinos, Arbustos,...)
    - Monstruos: Utilizados para la simulación del funcionamiento del Simon Dice original.

## Estructura de los scripts
- Canvas
  - [animationFigureController.cs](./scripts/animationFigureController.cs)
  - [movement.cs](./scripts/movement.cs)
  - [play.cs](./scripts/play.cs)

## Elementos externos usados
Los elementos usado los hemos sacado de la Asset Store.
- Montruos
- Contenido del bosque
- Audios

## Cuestiones importantes para el uso
- Para mejorar la jugabilidad, se recomienda usar un mando de Play Station 4 el cual ha sido configurado previamente.

![mando ps4](./images/MandoPlay.png)

- El mando tendrá la siguiente configuración de teclas:
  - **Joystick Izquierdo:** Utilizado para mover al jugador
  - **Pulsacion del panel tactil:** Utilizado para interaccionar con los elementos de la escena(perros/botones)

## Hitos de programación logrados
Para el desarrollo se han cumplido varias espectativas.

- Utilizacion de distancia entre dos objetos para la activacion del botón de play.
- Deteccion de eventos
- Deteccion de teclas de movimiento
- Programacion de animaciones de los monstruos
- Utilizacion de corutinas para poder utilizar retardos
- Sincronizacion de animaciones con sonidos

## Aspectos destacables del juego
- Realismo
  - Uso de sonidos de pasos para hacerlo mas realista
  - Uso de sonido de fondo de hoguera mas sonido neutral
- Uso de Rigidbody y Meshcollider para poder delimitar la zona de desplazamiento del jugador y guiarlo hacia el juego.
- Control de distancia del jugador al juego para que en el caso de que el jugador se aleje de la zona de juego el juego se cancele.


## Metodología de trabajo
-

## Reparto de tareas
-

## Gifs de demostración del juego
- Demo
![Demo](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/demo.gif)
- Animacion de fail
![Animacion de fail](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/pierde.gif) 
- Entorno
![Entorno](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/ojeada.gif)
- Animacion de boton
![Animacion de boton](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/distancia.gif)

## Enlaces de interés
- A continuación puede encontrar algunos enlaces que pueden resultar de su interés:
  
  ### APK
  - En el siguiente enlace puede encontrar la apk para dispositivos Android, la cual podrá descargar y probar:
    - [Enlace al APK](https://drive.google.com/file/d/1RY_FbbeazncxzWqu2AbKAqmCv6-LEY8c/view?usp=sharing)
   

## Posibles mejoras a futuro
- Se podria añadir complejidad añadiendo mas acciones de los monstruos las cuales tendras que memorizar y segun que boton pulses activaras una accion u otra de tal manera que podria un monstruo realizar una accion por ejemplo movimiento de cabeza y luego otro podria hacer animacion de atacar y asi el jugador deberia memorizar el orden y que accion hacia que monstruo.

