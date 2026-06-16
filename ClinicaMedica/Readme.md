# Clinica Medica

Estoy teniendo unos problemas con la base de datos, estuve un par de horas dandole vueltas y no logro hacer que lea la based de datos correctamente, la proxima clase en lo posible te ahre las consutlas en persona a ver si puedo solucionarlo (PD: yo no hice fork porque queria poner todo en el mismo repositorio entonces copie muchas cosas a mano asi que capaz el problema empezo desde ahi. sds)

## Estado actual

La lógica del sistema se encuentra implementada.

Actualmente existe un problema con la carga de la base de datos SQLite (`ClinicaMedica.db`) al ejecutar el proyecto en algunos entornos.

Error observado:

```text
SQLite Error 1: 'no such table: paciente'
```

Durante las pruebas se detectó que Visual Studio genera un archivo `ClinicaMedica.db` vacío dentro de:

bin/Debug/net10.0/

mientras que la base de datos original contiene las tablas y los datos esperados.