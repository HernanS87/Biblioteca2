# Biblioteca2 🏛️📚
# Trabajo Práctico: Colección de Datos
## Objetivo
El objetivo de este trabajo práctico es implementar una aplicación de gestión de una biblioteca con la capacidad de administrar una colección de lectores y préstamos de libros. La aplicación debe ser capaz de registrar lectores, realizar préstamos de libros y llevar un seguimiento de los préstamos vigentes.

## Descripción
La aplicación de la biblioteca tiene los siguientes requerimientos:

- La biblioteca debe llevar un registro de los lectores, incluyendo su nombre y número de identificación (DNI).
- Cada lector puede tener un máximo de 3 préstamos de libros vigentes al mismo tiempo.
- Cuando se realiza un préstamo, se retira el libro de la lista de libros de la biblioteca y se asigna al lector, si este cumple con los requisitos.
- Los posibles resultados de un préstamo son:
  - "PRESTAMO EXITOSO" (el libro se prestó al lector y se registró el préstamo).
  - "LIBRO INEXISTENTE" (el libro no está disponible en la biblioteca).
  - "TOPE DE PRESTAMO ALCANZADO" (el lector ya tiene tres libros en préstamo).
  - "LECTOR INEXISTENTE" (el lector no está registrado en la biblioteca).

### Tareas a Realizar 📝👩‍💻👨‍💻
Para cumplir con los requerimientos, se deben llevar a cabo las siguientes tareas:

1. Ampliar el UML (Diagrama de Clases) para reflejar los nuevos requerimientos del sistema, incluyendo las clases necesarias para representar a los lectores y los préstamos de libros.

2. Desarrollar el método altaLector que permita registrar a un nuevo lector en la lista de lectores de la biblioteca si no estaba previamente registrado.

3. Desarrollar el método prestarLibro de la clase Biblioteca, el cual debe recibir el título de un libro y el DNI del lector que lo solicita, y retornar uno de los siguientes valores:
  - "PRESTAMO EXITOSO" (el libro se prestó al lector y se registró el préstamo).
  - "LIBRO INEXISTENTE" (el libro no está disponible en la biblioteca).
  - "TOPE DE PRESTAMO ALCANZADO" (el lector ya tiene tres libros en préstamo).
  - "LECTOR INEXISTENTE" (el lector no está registrado en la biblioteca).
Con la implementación de estas funcionalidades, la biblioteca estará capacitada para gestionar su colección de lectores y préstamos de libros de manera eficiente.

1. [UML](https://lucid.app/lucidchart/4a084714-7030-41b4-a4b9-4c64084e4242/edit?invitationId=inv_879521b6-0571-46d6-9fcd-49f2c6fed290&page=0_0#) 
