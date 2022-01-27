# Simonsters
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
- [Reparto de tareas](#reparto-de-tareas)
- [Gifs de demostración del juego](#gifs-de-demostración-del-juego)
- [Enlaces de interés](#enlaces-de-interés)
  - [Gameplay del juego](#gameplay-del-juego)
  - [APK](#apk)
  - [Github del Proyecto para Unity](#github-del-proyecto-para-unity)
- [Posibles mejoras a futuro](#posibles-mejoras-a-futuro)

## Autores
  - Eduardo Expósito Barrera - alu0101230382@ull.edu.es
  - Carlos García Lezcano - alu0101208268@ull.edu.es
  - Cristo García González - alu0101204512@ull.edu.es
  - Andrés Zeus Hernández Impini - alu0101207957@ull.edu.es

## Introducción
- El juego desarrollado con el nombre de **Simonsters**, es un juego de **realidad virtual(VR)** desarrollado para dispositivos Android con Unity 3D.
  El mismo ha sido desarrollado a partir de diversas técnicas y conocimientos adquiridos durante la realización de la materia, además de algunas otras características que han sido necesarias aprender durante la realización del proyecto para su correcto funcionamiento.

  ### Descripción del juego
  - Cuando decides iniciar una partida en el juego que hemos desarrollado **Simonsters**, aparecerás en un escenario oscuro(simulando un bosque nocturno), el cual tiene un camino que te conduce hacia la jugabilidad del **Simonsters**, que es una variante del **Simon**. Una vez te acerques a la zona, te aparecerá un botón para comenzar a jugar. Si inicias una partida, puedes cancelar la misma pulsando el botón que aparece en la escena o alejándote de la zona de juego. En caso de equivocarte durante la partida, habrás perdido y deberás comenzar una nueva, en caso contrario, podrás llegar hasta un máximo de 10 niveles.
  
  ### Descripción del mapa
  - En el mapa que compone la escena desarrollada, podemos encontrar diferentes objetos, los cuales son:
    - Piedras
    - Hogueras
    - Antorchas
    - Niebla
    - Diversidad de flora(Pinos, Arbustos,...)
    - Monstruos: Utilizados para la simulación del funcionamiento del Simon Dice original.

## Estructura de los scripts
- Scripts desarrollados:
  - [animationFigureController.cs](./scripts/animationFigureController.cs)
  - [movement.cs](./scripts/movement.cs)
  - [play.cs](./scripts/play.cs)

## Elementos externos usados
- Los elementos que hemos usado para el desarrollo del juego, han sido descargados de la **Asset Store**. A continuación, mostramos la lista:
  - Montruos
  - Contenido del bosque(flora)
  - Niebla
  - Audios

## Cuestiones importantes para el uso
- Para mejorar la jugabilidad, se recomienda usar un mando de Play Station 4 el cual ha sido configurado previamente.

![mando ps4](./images/MandoPlay.png)

- El mando tendrá la siguiente configuración de teclas:
  - **Joystick Izquierdo:** Utilizado para mover al jugador
  - **Pulsación del panel táctil:** Utilizado para interaccionar con los elementos de la escena(monstruos/botones)

## Hitos de programación logrados
Como habíamos comentado anteriormente, para el desarollo del juego se han aplicado diversas técnicas y conocimientos adquiridos durante la realización de la materia, además de otras características que han sido necesarias aprender durante la realización del mismo. A continuación, listamos algunos de ellos:

- Utilización de distancia entre dos objetos para la activación del botón de play
- Aplicación de Delegados y Eventos
- Aplicación de movimiento mediante teclas
- Programación de animaciones
- Utilización de corutinas para poder utilizar retardos
- Sincronización de animaciones con sonidos
- Uso de elementos de la Asset Store(flora, monstruos,...)

## Aspectos destacables del juego
- Realismo
  - Uso de sonidos de pasos para hacerlo mas realista
  - Uso de sonido de fondo de hoguera mas sonido neutral
- Uso de Rigidbody y Meshcollider para poder delimitar la zona de desplazamiento del jugador y guiarlo hacia el juego.
- Control de distancia del jugador al juego para que en el caso de que el jugador se aleje de la zona de juego el juego se cancele.

## Reparto de tareas
- Eduardo Expósito Barrera
  - Comportamiento dinámico del botón
  - Ideas para mejora del algoritmo para secuencia

- Cristo García González
  - Ideas para mejora del algoritmo para secuencia
  - Creación de la decoración del escenario

- Carlos García González
  - Configuración del sistema Unity
  - Implementación del algortimo base 

- Andrés Zeus Hernández Impini
  - Sincronización de sonidos con las animaciones
  - Delimitación de la zona de juego
  
- Tareas Comunes
  - Implementación del movimiento del jugador 
  - Búsqueda de Assets 
  - Documentación 

## Gifs de demostración del juego
- Demo
![Demo](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/demo.gif)
- Animación de fail
![Animacion de fail](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/pierde.gif) 
- Entorno
![Entorno](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/ojeada.gif)
- Animación de botón
![Animacion de boton](https://github.com/lochdeve/Proyecto-Final-II/blob/main/gifs/distancia.gif)

## Enlaces de interés
- A continuación puede encontrar algunos enlaces que pueden resultar de su interés:
  ### Gameplay del juego
  - En el siguiente enlace puede encontrar una demostración del juego realizado:
    - [Enlace al vídeo del juego](https://drive.google.com/file/d/1hzqNp8U285nmJ2OsGPHD9R49x6mKDzPK/view)

  ### APK
  - En el siguiente enlace puede encontrar la apk para dispositivos Android, la cual podrá descargar y probar:
    - [Enlace al APK](https://github.com/lochdeve/Proyecto-Final-II/tree/main/apk)

  ### Github del Proyecto para Unity
  - En el siguiente enlace encontrará la dirección en la que se encuentra el proyecto completo para su ejecución en Unity:
    - [Enlace al proyecto](https://github.com/lochdeve/Proyecto-Final-II/tree/main/Simonsters)
   

## Posibles mejoras a futuro
- Se podría añadir complejidad añadiendo más acciones de los monstruos las cuales tendrás que memorizar y según que botón pulses activarás una acción u otra de tal manera que podría un monstruo realizar una acción por ejemplo movimiento de cabeza y luego otro podría hacer animación de atacar y así el jugador debería memorizar el orden y que acción hacia que monstruo.

