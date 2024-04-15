Docker Compose para Aplicación con MySQL, Backend en .NET y Frontend en Vue.js

Este repositorio contiene un conjunto de archivos Docker y un archivo Docker Compose para orquestar tres contenedores que trabajan juntos para proporcionar una aplicación web completa. La aplicación consta de:

- MySQL: Un contenedor que ejecuta una instancia de la base de datos MySQL.
- Backend en .NET: Un contenedor que aloja la lógica del servidor desarrollada en .NET.
- Frontend en Vue.js: Un contenedor que sirve la interfaz de usuario desarrollada en Vue.js.

Requisitos Previos
Docker: Asegúrate de tener Docker instalado en tu sistema. Puedes descargar e instalar Docker desde https://www.docker.com/get-started.
Uso

Como se usa:
Ejecuta el archivo Docker Compose para crear y levantar los contenedores. Este comando descargará las imágenes Docker necesarias, creará y ejecutará los contenedores.

docker-compose up

Una vez que los contenedores estén en funcionamiento, puedes acceder a la aplicación en tu navegador web:

Backend API en .NET: http://localhost:9090
Frontend Vue.js: http://localhost:8080

Estructura del Proyecto
docker-compose.yml: Archivo Docker Compose que define la configuración para todos los contenedores.
backend/: Directorio que contiene el código fuente del backend en .NET.
frontend/: Directorio que contiene el código fuente del frontend en Vue.js.
