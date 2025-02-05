# **Dwarfing Around**

## **1. Introducción**  
**Dwarfing Around** es un juego tipo *clicker* inspirado en títulos como *Cookie Clicker* o *Idle Slayer*. Su objetivo principal es cíclico: generar recursos para incrementar la velocidad de obtención de dichos recursos. Debido al tiempo limitado de desarrollo, el juego carece de una amplia variedad de mejoras, las cuales suelen ser numerosas en este género para extender su duración. Es un juego diseñado para jugarse en segundo plano.

---

## **2. Estructura del Proyecto**  

### **2.1. Descripción General de la Arquitectura**  
El proyecto se organiza en torno a dos clases principales: **DwarfController** y **StoreController**, que forman el núcleo del juego.  
- **DwarfController**: Gestiona la lógica de minería y el movimiento del personaje.  
- **StoreController**: Administra las mejoras y el sistema de puntuación.  

Ambas clases interactúan a través de referencias para sincronizar puntajes y niveles, permitiendo una integración fluida de las mecánicas del juego.

### **2.2. Clases y Scripts**  
Las principales clases y scripts son:  
- **DwarfController**: Controla el movimiento del personaje en la escena y utiliza *StoreController* para actualizar la puntuación.  
- **StoreController**: Se basa en tres características principales para cada mejora:  
  - **Nivel**: Indica el progreso de la mejora.  
  - **Precio**: Define el costo de desbloquear la mejora.  
  - **Valor añadido**: Determina el impacto de la mejora en el juego.  
- **DwarfPet**: Versión simplificada de *DwarfController* utilizada para animar al enano en la pantalla de título.  
- **CloudMovement**: Controla el desplazamiento de las nubes en el fondo.  
- **BackGroundMusicController**: Gestiona la música de fondo.  
- **MainMenuController**: Maneja los botones del menú principal (Jugar y Salir).  

### **2.3. Recursos Gráficos y Sonoros**  
- **Sprites y Texturas**: Todos los sprites fueron creados manualmente utilizando *Piskel*, incluyendo las animaciones de minería del enano.  
- **Sonidos y Música**: La música fue generada con *SunoAI* y editada con *Audacity*.

---

## **3. Desarrollo y Implementación**  

### **3.1. Mecánicas de Juego**  
Los enanos tienen un valor de poder que se suma a la puntuación total cada vez que realizan una acción de minería. Con esta puntuación, los jugadores pueden adquirir mejoras que incrementan la eficiencia de minería, creando un ciclo de retroalimentación continua.  
El sistema está diseñado para ser ampliado en futuras versiones, con ajustes en el equilibrio de velocidad y puntuación.

### **3.2. Interfaz de Usuario (UI)**  
La interfaz incluye:  
- **Parte superior derecha**: Visualización de la moneda del juego (*piedras*).  
- **Parte superior izquierda**: Cantidad de enanos trabajando actualmente.  
- **Zona central**: Botones para gestionar mejoras.  

### **3.3. Comportamiento de los Enanos**  
Los enanos comparten un parámetro común que define su poder de minería. Al generarse, su movimiento termina fuera de la pantalla para optimizar recursos y evitar superposiciones o errores visuales en las áreas de minería.

---

## **4. Herramientas y Tecnologías Utilizadas**  

### **4.1. Motor de Juego**  
El proyecto fue desarrollado en *Unity*.  

### **4.2. Lenguaje de Programación**  
El lenguaje principal utilizado fue *C#*.  

### **4.3. Otras Herramientas**  
- **Audacity**: Edición de música.  
- **Piskel**: Creación de sprites.  
- **Rider**: IDE para el desarrollo del código.  

---

## **5. Fuentes y Referencias**  
- **Proyectos de clase**: Base para el desarrollo.  
- **YouTube**: Tutoriales para la implementación de *canvas* y botones.  
- **ChatGPT**: Asistencia para resolver errores y optimizar estructuras de código.  

---

## **6. Desafíos y Soluciones**  
El principal desafío fue abordar todas las tareas del proyecto de forma autónoma, tanto en código como en la creación de recursos visuales y sonoros.  
- **Solución**: Refactorizar el código periódicamente para reducir la cantidad de scripts y reutilizar referencias externas. Esto mejoró la legibilidad y optimización del proyecto.  

---

## **7. Futuras Mejoras**  
El proyecto se encuentra en una fase temprana, pero tiene un gran potencial para futuras mejoras:  
- Implementar sonido al impactar con el pico.  
- Añadir animaciones al interactuar con los botones de mejoras.  
- Introducir nuevas mecánicas, como una moneda alternativa (*oro*) para reducir costos de mejoras o contratación de enanos.  
- Crear un menú de pausa para salir del juego.  
- Habilitar un sistema de guardado para continuar la partida en futuras sesiones.  
- Incorporar minería pasiva mientras el juego está cerrado.  

---

## **8. Conclusión**  
Estoy satisfecho con los resultados obtenidos, especialmente considerando el corto tiempo de desarrollo. Este proyecto me permitió comprender la importancia de refactorizar código para optimizar y mejorar la comprensión general del proyecto. Aunque todavía hay mucho por mejorar, me siento motivado para seguir desarrollándolo y llevarlo a un nivel más avanzado.  
