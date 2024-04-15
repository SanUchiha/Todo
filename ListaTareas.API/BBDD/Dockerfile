# Utiliza la imagen oficial de MySQL desde Docker Hub
FROM mysql:latest

# Establece las variables de entorno para la base de datos
ENV MYSQL_ROOT_PASSWORD=29101988aA..
ENV MYSQL_DATABASE=tododb
ENV MYSQL_USER=jose
ENV MYSQL_PASSWORD=29101988aA..

# Copia el script de inicialización a la ubicación específica
COPY init.sql /docker-entrypoint-initdb.d/
