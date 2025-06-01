# Proyecto Calculadora y Sistema de Personal - C#

## Descripción general

Este repositorio contiene dos proyectos de consola desarrollados en C# con .NET, organizados en carpetas separadas:

### 1. Calculadora

- Proyecto de consola que implementa una clase `Calculadora` con métodos para realizar operaciones aritméticas básicas: sumar, restar, multiplicar, dividir.
- La clase mantiene un valor interno (`dato`) que se modifica con cada operación.
- Permite encadenar operaciones sobre el mismo resultado.
- Incluye un método para limpiar el resultado (`Limpiar`).
- Se creó una interfaz de consola sencilla que permite al usuario realizar operaciones hasta que ingrese el comando `salir`.

### 2. SisPersonal

- Proyecto de consola para administrar información básica de empleados de una empresa.
- Define una clase `Empleado` con atributos como nombre, apellido, fecha de nacimiento, estado civil, fecha de ingreso, sueldo básico y cargo.
- Se utiliza un `enum` para los cargos: Auxiliar, Administrativo, Ingeniero, Especialista e Investigador.
- Implementa métodos para calcular:
  - Antigüedad en la empresa
  - Edad
  - Años faltantes para jubilarse (considerando 65 años como edad de jubilación)
  - Salario total que incluye un adicional según antigüedad, cargo y estado civil.
- Carga datos de 3 empleados en un arreglo.
- Calcula el monto total a pagar en salarios.
- Muestra el empleado que está más próximo a jubilarse, con toda su información relevante.

## Cómo ejecutar

1. Clonar el repositorio.
2. Navegar a la carpeta `Calculadora` o `SisPersonal`.
3. Ejecutar el comando `dotnet run` para cada proyecto.
4. Seguir las instrucciones en consola para interactuar con cada programa.

## ⚠️ Aclaración sobre los commits

Durante el desarrollo del proyecto, uno de los commits fue realizado desde una computadora de uso común en la facultad, la cual estaba configurada con la cuenta de GitHub de otro alumno (**Frank9897**).  
**Todo el trabajo fue realizado íntegramente por Lucas Mariano Delgado**, y la aparición de otro usuario como contribuyente es un error técnico.

---

## Autor

**Lucas Mariano Delgado** 
