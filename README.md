# 🛠️ Dwarfing Around  (v.0.2)

**Dwarfing Around** es un juego tipo *clicker* inspirado en títulos como *Cookie Clicker* y *Idle Slayer*. Su objetivo es generar recursos para adquirir mejoras que aumentan la velocidad de recolección, fomentando un ciclo de progresión continuo.  

---

## 📥 Clonar y Configurar el Proyecto  

Para descargar y ejecutar el proyecto correctamente en *Unity*, sigue estos pasos:  

### **1️⃣ Clonar el Repositorio**  
Abre una terminal y ejecuta el siguiente comando:  

```bash
git clone https://github.com/tu-usuario/dwarfing-around.git
```

🔹 **Nota:** La carpeta `Library` está excluida en `.gitignore` para reducir el peso del repositorio. *Unity* la regenerará automáticamente al abrir el proyecto.  

---

### **2️⃣ Abrir el Proyecto en Unity**  
1. Abre **Unity Hub**.  
2. Selecciona la opción **"Open"** y busca la carpeta donde clonaste el proyecto.  
3. Espera a que *Unity* importe todos los archivos y genere la carpeta `Library`.  

---

### **3️⃣ Configurar Dependencias**  
Si al abrir el proyecto faltan paquetes o aparecen errores en los scripts, sigue estos pasos:  
- Accede a **Window > Package Manager** en *Unity* y verifica que los paquetes esenciales de desarrollo 2D estén instalados.  
- Si hay problemas con los scripts, revisa la configuración del editor de código en **Edit > Preferences > External Tools**, asegurándote de que *Rider* o *Visual Studio* estén correctamente vinculados.  

---

## 🎮 Estado Actual del Proyecto  
✔️ Mecánica básica de minería funcionando.  
✔️ Interfaz de usuario con sistema de mejoras.  
✔️ Animaciones y sprites personalizados creados en *Piskel*.  
✔️ Música y sonidos generados con *SunoAI* y editados con *Audacity*.

🚧 **En desarrollo:**  
- Ajuste del equilibrio en la progresión de mejoras.  
- Implementación de un menú de pausa.
- Optimización del proyecto general (hay que destruir el GameObject residual que deja cada enano cuando entra a la mina).

---

## 🔮 Futuras Mejoras  
📌 Sonido al impactar con el pico.
📌 Sustituir la música generada por IA por algo de composición propia, que cambie dinámicamente.
📌 Animaciones al interactuar con los botones de mejoras.  
📌 Sistema de guardado para continuar partidas en futuras sesiones.  
📌 Minería pasiva mientras el juego está cerrado.  
📌 Mejoras visuales.

---

## 💡 Contribuciones  
Si deseas contribuir al proyecto, puedes hacer un *fork* en GitHub, trabajar en una mejora y enviar un *pull request* para revisión. O escríbeme directamente.

---

## 📝 Licencia  
Este proyecto se distribuye bajo la licencia [MIT](LICENSE) y [CC-BY](LICENSE).  

---
